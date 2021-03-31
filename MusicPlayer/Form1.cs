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
            ofOpen.Filter = "Arquivo mp4|*.mp4|Arquivo mp3|*.mp3";
            //Caixa de dialogo para o usuario selecionar os arquivos de audio ou de video
            //Se o usuario selecionou um arquivo
            if (ofOpen.ShowDialog() == DialogResult.OK) {
                //Após selecionar todo que ira ser colocado na playlist
                playList = player.playlistCollection.newPlaylist("List");
                //Para cada arquivo selecionado na playlist
                foreach (var arquivo in ofOpen.FileNames) {
                    //Add cada item para a playlist
                    playList.appendItem(player.newMedia(arquivo));
                    //Add na playlist
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
    }
}
