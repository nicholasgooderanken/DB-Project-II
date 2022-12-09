using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarthProject
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }
        const int NUMELEMENTS = 16;

       

        private void btnMainPage_Click(object sender, EventArgs e)
        {
            gotomainPage();
        }

        private void gotomainPage()
        {//shows main form
            Form mainForm = new frmMain();
            this.Hide();
            mainForm.ShowDialog();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            exitProgramOrNot();
        }

        private void exitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show(
"Do You Really Want To Exit The Program?",
"EXIT NOW?",
MessageBoxButtons.YesNo,
MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {// loads all images into the places on the splashscreen from the album images class
            pb00.Image = Image.FromFile(AlbumImages.images[0]);
            pb01.Image = Image.FromFile(AlbumImages.images[1]);
            pb02.Image = Image.FromFile(AlbumImages.images[2]);
            pb03.Image = Image.FromFile(AlbumImages.images[3]);
            pb04.Image = Image.FromFile(    AlbumImages.images[4]);
            pb05.Image = Image.FromFile(AlbumImages.images[5]);
            pb06.Image = Image.FromFile(AlbumImages.images[6]);
            pb07.Image = Image.FromFile(AlbumImages.images[7]);
            pb08.Image = Image.FromFile(AlbumImages.images[8]);
            pb09.Image = Image.FromFile(AlbumImages.images[9]);
            pb10.Image = Image.FromFile(AlbumImages.images[10]);
            pb11.Image = Image.FromFile(AlbumImages.images[11]);
            pb12.Image = Image.FromFile(AlbumImages.images[12]);
            pb13.Image = Image.FromFile(AlbumImages.images[13]);
            pb14.Image = Image.FromFile(AlbumImages.images[14]);
            pb15.Image = Image.FromFile(AlbumImages.images[15]);
        }

        private void MainPageMenuItem_Click(object sender, EventArgs e)
        {
            gotomainPage();
        }

        private void helpMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Provided By Students", "YOU do This", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            exitProgramOrNot();
        }
    }
}
