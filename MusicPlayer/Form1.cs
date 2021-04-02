using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MusicPlayer {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void player_Enter(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        //Variavel da playlist
        WMPLib.IWMPPlaylist playList;

        private void button1_Click(object sender, EventArgs e) {
            //Titulo do botão
            ofOpen.Title = "Abrir mídia";
            //Filtro
            ofOpen.Filter = "Arquivo mp4|*.mp4";
            ofOpen.Filter = "Arquivo mp3|*.mp3";
            //Caixa de dialogo para o usuario selecionar os arquivos de audio ou de video
            //Se o usuario selecionou um arquivo
            if (ofOpen.ShowDialog() == DialogResult.OK) {
                //Após selecionar todo que ira ser colocado na playlist
                playList = player.playlistCollection.newPlaylist("List");
                //Para cada arquivo selecionado na playlist
                foreach (var arquivo in ofOpen.FileNames) {
                    //Add cada item para a playlist
                    playList.appendItem(player.newMedia(arquivo));
                    listPlayList.Items.Add(arquivo);
                    //Dando o play na execução
                    player.currentPlaylist = playList;
                    player.Ctlcontrols.play();
                }
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            //Se na playlist tiver arquivos
            if (listPlayList.Items.Count > 0) {
                //Caixa de dialogo salvar
                ofSave.Title = "Salvar Playlist";
                ofSave.Filter = "Arquivo texto|*.txt";
                //Se tiver arquivos para salvar
                if (ofSave.ShowDialog() == DialogResult.OK) {
                    //Escrever um arquivo texto e salva, o false é para que se tiver um arquivo com o nome ele sobrescreve
                    StreamWriter arquivo = new StreamWriter(ofSave.FileName, false);
                    //Salvar a lista, varrendo o ListBox salvando no arquivo
                    for (int i = 0; i < listPlayList.Items.Count; i++) {
                        //Adiconando dentro do arquivo
                        arquivo.WriteLine(listPlayList.Items[i].ToString());
                    }
                    //Sempre fechar o arquivo depois de sair da opção
                    arquivo.Close();
                }

            }
        }

        private void btnLoad_Click(object sender, EventArgs e) {
            //Titulo do botão
            ofOpen.Title = "Abrir Playlist";
            //Filtro
            ofOpen.Filter = "Arquivo texto|*.txt";
            //
            ofOpen.Multiselect = false;
            //Se abrir o  arquivo
            if (ofOpen.ShowDialog() == DialogResult.OK) {
                //Le o arquivo
                StreamReader arquivo = new StreamReader(ofOpen.FileName);
                //Coloca o arquivo na ListBox
                while (arquivo.Peek() != -1) {
                    //Adiconando na playlist
                    listPlayList.Items.Add(arquivo.ReadLine());
                }
                //Sempre fechar o arquivo depois de sair da opção
                arquivo.Close();
            }
        }

        private void listPlayList_DoubleClick(object sender, EventArgs e) {
            //Se tem item na lista
            if (listPlayList.Items.Count > 0) {
                //Executando o arquivo
                player.URL = listPlayList.SelectedItem.ToString();
                player.Ctlcontrols.play();
            }
        }

        private void btnClear_Click(object sender, EventArgs e) {
            //Se tiver executando algo ja da um stop
            player.Ctlcontrols.stop();
            listPlayList.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e) {
            //Para cada item selecionado
            foreach (var items in officialPlaylist.SelectedItems) {
                //Adiciona cada item na playlist provisoria
                listPlayList.Items.Add(items);
            }
            //Para cada item selecionado na playlist oficial 
            for (int i = officialPlaylist.SelectedItems.Count - 1; i >= 0; i--) {
                //Remove o item na posição i
                officialPlaylist.Items.Remove(officialPlaylist.SelectedItems[i]);
            }
        }

        private void button1_Click_1(object sender, EventArgs e) {
            //Paraos items na playlist provisoria
            foreach (var items in listPlayList.Items) {
                //Adiciona os items na playlist oficial
                officialPlaylist.Items.Add(items);
            }

            listPlayList.Items.Clear();
        }

        private void oneFileForOfficial_Click(object sender, EventArgs e) {
            //Adicionar um item selecionado para a playlist oficial
            officialPlaylist.Items.Add(listPlayList.SelectedItem);
            //Removendo o item da playlist provisoria
            int i = 0;
            i = listPlayList.SelectedIndex;
            listPlayList.Items.RemoveAt(i);
        }

        private void oneFileForProvisional_Click(object sender, EventArgs e) {
            //Adicionar um item selecionado para a playlist provisoria
            listPlayList.Items.Add(officialPlaylist.SelectedItem);
            //Removendo o item da playlist oficial
            int i = 0;
            i = officialPlaylist.SelectedIndex;
            officialPlaylist.Items.RemoveAt(i);
        }

        private void selectedFilesForOfficial_Click(object sender, EventArgs e) {
            //Para cada item selecionado
            foreach (var items in listPlayList.SelectedItems) {
                //Adiciona cada item na playlist oficial
                officialPlaylist.Items.Add(items);
            }
            //Para cada item selecionado na playlist provisoria 
            for (int i = listPlayList.SelectedItems.Count - 1; i >= 0; i--) {
                //Remove o item na posição i
                listPlayList.Items.Remove(listPlayList.SelectedItems[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            //Para cada item na playlist oficial
            foreach (var items in officialPlaylist.Items) {
                //Adiciona cada item na playlist provisoria
                listPlayList.Items.Add(items);
            }

            officialPlaylist.Items.Clear();
        }

        private void listPlayList_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void officialPlaylist_DoubleClick(object sender, EventArgs e) {
            //Se tem item na lista
            if (officialPlaylist.Items.Count > 0) {
                //Executando o arquivo
                player.URL = officialPlaylist.SelectedItem.ToString();
                player.Ctlcontrols.play();
            }
        }

        private void removeSelectedFile_Click(object sender, EventArgs e) {
            //Para cada item selecionado na playlist provisoria 
            for (int i = listPlayList.SelectedItems.Count - 1; i >= 0; i--) {
                //Remove o item na posição i
                listPlayList.Items.Remove(listPlayList.SelectedItems[i]);
            }

            for (int i = officialPlaylist.SelectedItems.Count - 1; i >= 0; i--) {
                //Remove o item na posição i
                officialPlaylist.Items.Remove(officialPlaylist.SelectedItems[i]);
            }
        }
    }
}
