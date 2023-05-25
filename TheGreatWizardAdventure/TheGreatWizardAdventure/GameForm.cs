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
    public class Charactor
    {

    }

    static public class Mouse
    {
        static int mouseX;
        static int mouseY;
    }

    public partial class GameForm : Form
    {


        public GameForm()
        {
            InitializeComponent();
            init();

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
            for (; ; )
            {
   
            }
        }

        private void GameForm_MouseMove(object sender, MouseEventArgs e)
        {
            mouseX = e.Location.X;
            mouseY = e.Location.Y;
            label1.Text = e.Location.X.ToString();
            label2.Text = e.Location.Y.ToString();
        }
    }
}
