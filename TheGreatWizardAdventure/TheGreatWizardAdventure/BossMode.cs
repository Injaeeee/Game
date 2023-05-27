using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGreatWizardAdventure
{
    public partial class BossMode : Form
    {
        public BossMode()
        {
            InitializeComponent();
            InitializeMovement();
        }
        private void InitializeMovement()
        {

        }

        private void Boss_Click(object sender, EventArgs e)
        {
            if (Cursor.Position.X > 880)
            {
                magician.Image = Properties.Resources.마법사오른쪽빔;
                //RightLaser.Visible = true;

            }
            else
            {
                magician.Image = Properties.Resources.마법사왼쪽빔;
                //leftlaser.Visible = true;
            }
        }

        private void BossMode_MouseMove(object sender, MouseEventArgs e)
        {


            
        }


    }

}
