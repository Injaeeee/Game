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
        public class Charactor
        {

        }

        static public class Mouse
        {
            public static int MouseX { get; private set; }
            public static int MouseY { get; private set; }

            public static void UpdateMousePosition(int x, int y)
            {
                MouseX = x;
                MouseY = y;
            }
        }

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
                if (Mouse.MouseX > 900)
                {
                    charactor.Location.X
                }
                else
                {

                }
            }
        }

        private void GameForm_MouseMove(object sender, MouseEventArgs e)
        {
            Mouse.UpdateMousePosition(e.Location.X, e.Location.Y);
            label1.Text = e.Location.X.ToString();
            label2.Text = e.Location.Y.ToString();
        }
    }
}
