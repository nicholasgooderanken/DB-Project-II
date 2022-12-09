namespace GarthProject
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSplashScreeen = new System.Windows.Forms.Button();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.LoadDataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splashScreenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAlbumSearch = new System.Windows.Forms.Button();
            this.txtAlbumSearch = new System.Windows.Forms.TextBox();
            this.dgvAlbumFacts = new System.Windows.Forms.DataGridView();
            this.dgvSongs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbumFacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSplashScreeen
            // 
            this.btnSplashScreeen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSplashScreeen.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSplashScreeen.Location = new System.Drawing.Point(1269, 54);
            this.btnSplashScreeen.Name = "btnSplashScreeen";
            this.btnSplashScreeen.Size = new System.Drawing.Size(178, 73);
            this.btnSplashScreeen.TabIndex = 39;
            this.btnSplashScreeen.Text = "Splash Screen";
            this.btnSplashScreeen.UseVisualStyleBackColor = true;
            this.btnSplashScreeen.Click += new System.EventHandler(this.btnSplashScreeen_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadData.Location = new System.Drawing.Point(254, 54);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(178, 64);
            this.btnLoadData.TabIndex = 38;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1519, 445);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadDataMenuItem,
            this.splashScreenMenuItem,
            this.albumSearchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1543, 24);
            this.menuStrip1.TabIndex = 41;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // LoadDataMenuItem
            // 
            this.LoadDataMenuItem.Name = "LoadDataMenuItem";
            this.LoadDataMenuItem.Size = new System.Drawing.Size(72, 20);
            this.LoadDataMenuItem.Text = "Load Data";
            this.LoadDataMenuItem.Click += new System.EventHandler(this.LoadDataMenuItem_Click);
            // 
            // splashScreenMenuItem
            // 
            this.splashScreenMenuItem.Name = "splashScreenMenuItem";
            this.splashScreenMenuItem.Size = new System.Drawing.Size(91, 20);
            this.splashScreenMenuItem.Text = "Splash Screen";
            this.splashScreenMenuItem.Click += new System.EventHandler(this.splashScreenMenuItem_Click);
            // 
            // albumSearchToolStripMenuItem
            // 
            this.albumSearchToolStripMenuItem.Name = "albumSearchToolStripMenuItem";
            this.albumSearchToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.albumSearchToolStripMenuItem.Text = "Album Search";
            this.albumSearchToolStripMenuItem.Click += new System.EventHandler(this.albumSearchToolStripMenuItem_Click);
            // 
            // btnAlbumSearch
            // 
            this.btnAlbumSearch.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlbumSearch.Location = new System.Drawing.Point(456, 54);
            this.btnAlbumSearch.Name = "btnAlbumSearch";
            this.btnAlbumSearch.Size = new System.Drawing.Size(213, 64);
            this.btnAlbumSearch.TabIndex = 42;
            this.btnAlbumSearch.Text = "Album Search";
            this.btnAlbumSearch.UseVisualStyleBackColor = true;
            this.btnAlbumSearch.Click += new System.EventHandler(this.btnAlbumSearch_Click);
            // 
            // txtAlbumSearch
            // 
            this.txtAlbumSearch.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlbumSearch.Location = new System.Drawing.Point(675, 55);
            this.txtAlbumSearch.Name = "txtAlbumSearch";
            this.txtAlbumSearch.Size = new System.Drawing.Size(588, 63);
            this.txtAlbumSearch.TabIndex = 43;
            // 
            // dgvAlbumFacts
            // 
            this.dgvAlbumFacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlbumFacts.Location = new System.Drawing.Point(755, 620);
            this.dgvAlbumFacts.Name = "dgvAlbumFacts";
            this.dgvAlbumFacts.Size = new System.Drawing.Size(776, 239);
            this.dgvAlbumFacts.TabIndex = 47;
            // 
            // dgvSongs
            // 
            this.dgvSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSongs.Location = new System.Drawing.Point(12, 620);
            this.dgvSongs.Name = "dgvSongs";
            this.dgvSongs.Size = new System.Drawing.Size(724, 239);
            this.dgvSongs.TabIndex = 48;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnLoadData;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSplashScreeen;
            this.ClientSize = new System.Drawing.Size(1543, 871);
            this.Controls.Add(this.dgvSongs);
            this.Controls.Add(this.dgvAlbumFacts);
            this.Controls.Add(this.txtAlbumSearch);
            this.Controls.Add(this.btnAlbumSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSplashScreeen);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Garth Brooks DB project - Main Screen";
            this.Load += new System.EventHandler(this.frmSplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbumFacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSplashScreeen;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem LoadDataMenuItem;
        private System.Windows.Forms.ToolStripMenuItem splashScreenMenuItem;
        private System.Windows.Forms.Button btnAlbumSearch;
        private System.Windows.Forms.TextBox txtAlbumSearch;
        private System.Windows.Forms.ToolStripMenuItem albumSearchToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvAlbumFacts;
        private System.Windows.Forms.DataGridView dgvSongs;
    }
}