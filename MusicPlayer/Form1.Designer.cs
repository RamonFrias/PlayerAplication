
namespace MusicPlayer {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.listPlayList = new System.Windows.Forms.ListBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.ofOpen = new System.Windows.Forms.OpenFileDialog();
            this.ofSave = new System.Windows.Forms.SaveFileDialog();
            this.officialPlaylist = new System.Windows.Forms.ListBox();
            this.oneFileForOfficial = new System.Windows.Forms.Button();
            this.selectedFilesForOfficial = new System.Windows.Forms.Button();
            this.oneFileForProvisional = new System.Windows.Forms.Button();
            this.selecteFilesForProvisional = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.removeSelectedFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(12, 12);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(909, 301);
            this.player.TabIndex = 0;
            this.player.Enter += new System.EventHandler(this.player_Enter);
            // 
            // listPlayList
            // 
            this.listPlayList.FormattingEnabled = true;
            this.listPlayList.Location = new System.Drawing.Point(12, 319);
            this.listPlayList.Name = "listPlayList";
            this.listPlayList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listPlayList.Size = new System.Drawing.Size(361, 238);
            this.listPlayList.TabIndex = 1;
            this.listPlayList.SelectedIndexChanged += new System.EventHandler(this.listPlayList_SelectedIndexChanged);
            this.listPlayList.DoubleClick += new System.EventHandler(this.listPlayList_DoubleClick);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(303, 563);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(70, 55);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(390, 563);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 55);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(561, 563);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 55);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load FIle";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(475, 563);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(70, 55);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear Provisional List";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // officialPlaylist
            // 
            this.officialPlaylist.FormattingEnabled = true;
            this.officialPlaylist.Location = new System.Drawing.Point(561, 319);
            this.officialPlaylist.Name = "officialPlaylist";
            this.officialPlaylist.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.officialPlaylist.Size = new System.Drawing.Size(360, 238);
            this.officialPlaylist.TabIndex = 6;
            this.officialPlaylist.DoubleClick += new System.EventHandler(this.officialPlaylist_DoubleClick);
            // 
            // oneFileForOfficial
            // 
            this.oneFileForOfficial.Location = new System.Drawing.Point(424, 319);
            this.oneFileForOfficial.Name = "oneFileForOfficial";
            this.oneFileForOfficial.Size = new System.Drawing.Size(85, 36);
            this.oneFileForOfficial.TabIndex = 7;
            this.oneFileForOfficial.Text = ">";
            this.oneFileForOfficial.UseVisualStyleBackColor = true;
            this.oneFileForOfficial.Click += new System.EventHandler(this.oneFileForOfficial_Click);
            // 
            // selectedFilesForOfficial
            // 
            this.selectedFilesForOfficial.Location = new System.Drawing.Point(424, 361);
            this.selectedFilesForOfficial.Name = "selectedFilesForOfficial";
            this.selectedFilesForOfficial.Size = new System.Drawing.Size(85, 37);
            this.selectedFilesForOfficial.TabIndex = 8;
            this.selectedFilesForOfficial.Text = ">>";
            this.selectedFilesForOfficial.UseVisualStyleBackColor = true;
            this.selectedFilesForOfficial.Click += new System.EventHandler(this.selectedFilesForOfficial_Click);
            // 
            // oneFileForProvisional
            // 
            this.oneFileForProvisional.Location = new System.Drawing.Point(424, 404);
            this.oneFileForProvisional.Name = "oneFileForProvisional";
            this.oneFileForProvisional.Size = new System.Drawing.Size(85, 37);
            this.oneFileForProvisional.TabIndex = 9;
            this.oneFileForProvisional.Text = "<";
            this.oneFileForProvisional.UseVisualStyleBackColor = true;
            this.oneFileForProvisional.Click += new System.EventHandler(this.oneFileForProvisional_Click);
            // 
            // selecteFilesForProvisional
            // 
            this.selecteFilesForProvisional.Location = new System.Drawing.Point(424, 447);
            this.selecteFilesForProvisional.Name = "selecteFilesForProvisional";
            this.selecteFilesForProvisional.Size = new System.Drawing.Size(85, 35);
            this.selecteFilesForProvisional.TabIndex = 10;
            this.selecteFilesForProvisional.Text = "<<";
            this.selecteFilesForProvisional.UseVisualStyleBackColor = true;
            this.selecteFilesForProvisional.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 563);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 55);
            this.button1.TabIndex = 11;
            this.button1.Text = "To move all for official playlist";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(667, 563);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 55);
            this.button2.TabIndex = 12;
            this.button2.Text = "To move all for provisional playlist";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // removeSelectedFile
            // 
            this.removeSelectedFile.Location = new System.Drawing.Point(401, 501);
            this.removeSelectedFile.Name = "removeSelectedFile";
            this.removeSelectedFile.Size = new System.Drawing.Size(133, 32);
            this.removeSelectedFile.TabIndex = 13;
            this.removeSelectedFile.Text = "Remove selected file";
            this.removeSelectedFile.UseVisualStyleBackColor = true;
            this.removeSelectedFile.Click += new System.EventHandler(this.removeSelectedFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 630);
            this.Controls.Add(this.removeSelectedFile);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selecteFilesForProvisional);
            this.Controls.Add(this.oneFileForProvisional);
            this.Controls.Add(this.selectedFilesForOfficial);
            this.Controls.Add(this.oneFileForOfficial);
            this.Controls.Add(this.officialPlaylist);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.listPlayList);
            this.Controls.Add(this.player);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.ListBox listPlayList;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.OpenFileDialog ofOpen;
        private System.Windows.Forms.SaveFileDialog ofSave;
        private System.Windows.Forms.ListBox officialPlaylist;
        private System.Windows.Forms.Button oneFileForOfficial;
        private System.Windows.Forms.Button selectedFilesForOfficial;
        private System.Windows.Forms.Button oneFileForProvisional;
        private System.Windows.Forms.Button selecteFilesForProvisional;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button removeSelectedFile;
    }
}

