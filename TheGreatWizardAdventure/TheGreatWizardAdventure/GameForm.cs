using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGreatWizardAdventure.Container
{

    

    
    public partial class GameForm : Form
    {

        bool soundcheck = true;

        public GameForm()
        {
            InitializeComponent();
            init();

            gamePlay();
            

        }


        public void init()
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void mousePosition()
        {
            label1.Text = Cursor.Position.X.ToString();
            label2.Text = Cursor.Position.Y.ToString();
        }

        private void gamePlay()
        {
            /*
            for (; ; )
            {
                if (Cursor.Position.X > 500)
                {
                    magician.Image = Properties.Resources.마법사오른쪽스텐딩;
                }
                else
                {
                    magician.Image = Properties.Resources.마법사왼쪽스텐딩;
                }
            }
            */
        }

        private void GameForm_MouseMove(object sender, MouseEventArgs e)
        {
            //mouseX = e.Location.X;
            //mouseY = e.Location.Y;
            label1.Text = e.Location.X.ToString();
            label2.Text = e.Location.Y.ToString();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void SoundButton_Click(object sender, EventArgs e)
        {
            if (soundcheck == true)
            {
                SoundButton.Image = Properties.Resources.Icon_SoundOff;
                soundcheck = false;
            }
            else
            {
                SoundButton.Image = Properties.Resources.Icon_SoundOn;
                soundcheck = true;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            MenuForm showForm = new MenuForm();
              this.Hide();
            showForm.ShowDialog();


        }
    }
}
