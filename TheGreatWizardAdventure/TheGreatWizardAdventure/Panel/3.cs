using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGreatWizardAdventure.Panel
{
    public partial class _3 : UserControl
    {
        private bool isAImageShown = false;

        public _3()
        {
            InitializeComponent();
            InitializeVisibility();

        }
        private void InitializeVisibility()
        {
            visibilityTimer = new Timer();
            visibilityTimer.Interval = 1500; // 1.5초 설정
            visibilityTimer.Tick += visibilityTimer_Tick;


            visibilityTimer.Start();
        }
        private void visibilityTimer_Tick(object sender, EventArgs e)
        {
            if (isAImageShown)
            {
                magician.Image = Properties.Resources.마법사오른쪽스텐딩; // 원래 이미지로 변경
                magician2.Image = Properties.Resources.마법사오른쪽스텐딩; // 원래 이미지로 변경
                leftlabel.Visible = false;
                rightlabel.Visible = false;
            }
            else
            {
                magician.Image = Properties.Resources.마법사오른쪽빔; // 물 이미지로 변경
                magician2.Image = Properties.Resources.불마법사오른쪽빔; // 불 이미지로 변경
                leftlabel.Visible = true;
                rightlabel.Visible = true;
            }

            isAImageShown = !isAImageShown;
        }
    }
}
