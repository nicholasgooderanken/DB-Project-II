using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicLibrary;

namespace GarthProject
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        BindingSource albumBindingSource = new BindingSource();
        BindingSource songBindingSource = new BindingSource();
        BindingSource albumFactsSource = new BindingSource();
        AlbumsDAO albumsDAO = new AlbumsDAO();

       


        private void button2_Click(object sender, EventArgs e)
        {
            
        }

       

        private void btnMainPage_Click(object sender, EventArgs e)
        {
        
        }

       

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            loadAllMusicData();
            
            
        }

        private void loadAllMusicData()
        {AlbumsDAO albumsDAO = new AlbumsDAO();
            //actually loads all of the data found in the databse into the gridview


            albumBindingSource.DataSource = albumsDAO.getAllAlbums();
            dataGridView1.DataSource = albumBindingSource;

        }

        private void loadAlbumFacts(object sender)
        {
            DataGridView dgv = (DataGridView)sender;
            AlbumsDAO albumsDAO = new AlbumsDAO();
            int rowClicked = dgv.CurrentRow.Index;
            albumFactsSource.DataSource = albumsDAO.getAlbumFacts((int)dataGridView1.Rows[rowClicked].Cells[0].Value);
            dgvAlbumFacts.DataSource = albumFactsSource;

        }

        private void btnSplashScreeen_Click(object sender, EventArgs e)
        {
            gotoSplash();
        }

        private void gotoSplash()
        {//takes you to splash screen
            Form splashScreen = new frmSplash();
            this.Hide();
            splashScreen.ShowDialog();
        }

        private void LoadDataMenuItem_Click(object sender, EventArgs e)
        {
            loadAllMusicData();
        }

        private void splashScreenMenuItem_Click(object sender, EventArgs e)
        {
            gotoSplash();
        }

        private void btnAlbumSearch_Click(object sender, EventArgs e)
        {
            loadSearchMusicData();
        }

        private void loadSearchMusicData()
        {// fills datagridview  based on search term and takes the picture that was in the picture box(if there was one) off of it
            AlbumsDAO albumsDAO= new AlbumsDAO();

            albumBindingSource.DataSource = albumsDAO.getSearchAlbums(txtAlbumSearch.Text);
            dataGridView1.DataSource = albumBindingSource;
          
        }

        private void albumSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadSearchMusicData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {//places image in picture box based on which album cell you click on 
            DataGridView dgv = (DataGridView)sender;
            int rowClicked = dgv.CurrentRow.Index;

            AlbumsDAO albumsDAO = new AlbumsDAO();
            loadAlbumFacts(sender);
            songBindingSource.DataSource = albumsDAO.getSongsForAlbum((int)dataGridView1.Rows[rowClicked].Cells[0].Value);
            //albumFactsSource.DataSource = albumsDAO.getAlbumFacts((int)dataGridView1.Rows[rowClicked].Cells[0].Value);
            dgvSongs.DataSource = songBindingSource;
            //dgvAlbumFacts.DataSource = albumFactsSource;



        }













        private void clearOutAddNewRecordFields()
        {
        }
    }
}
