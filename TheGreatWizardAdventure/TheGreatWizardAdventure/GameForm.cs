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

 

        private void mousePosition()
        {
            label1.Text = Cursor.Position.X.ToString();
            label2.Text = Cursor.Position.Y.ToString();
        }

        private void gamePlay()
        {
      

    
            
            
            
        }

        private void GameForm_MouseMove(object sender, MouseEventArgs e)
        {
            //mouseX = e.Location.X;
            //mouseY = e.Location.Y;
            label1.Text = e.Location.X.ToString();
            label2.Text = e.Location.Y.ToString();

            if (Cursor.Position.X > 900)
            {
                magician.Image = Properties.Resources.마법사오른쪽스텐딩;
                if(Cursor.Position.X > 1100)
                    magician.Image = Properties.Resources.마법사오른쪽걷기;


            }
            else
            {
                magician.Image = Properties.Resources.마법사왼쪽스텐딩;
                if(Cursor.Position.X < 600)
                    magician.Image = Properties.Resources.마법사왼쪽걷기;
            }

            RightLaser.Visible = false;
            leftlaser.Visible = false;
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            RightLaser.Visible = false;
            leftlaser.Visible = false;
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

        private void Monster_Click(object sender, EventArgs e)
        {
            if (Cursor.Position.X > 880)
            {
                magician.Image = Properties.Resources.마법사오른쪽빔;
                RightLaser.Visible = true;

            }
            else
            {
                magician.Image = Properties.Resources.마법사왼쪽빔;
                leftlaser.Visible = true;
            }
        }
    }
}
