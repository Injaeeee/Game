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
            visibilityTimer.Interval = 800; // 1.5초 설정
            visibilityTimer.Tick += visibilityTimer_Tick;


            visibilityTimer.Start();
        }
        private void visibilityTimer_Tick(object sender, EventArgs e)
        {
            if (isAImageShown)
            {
                magician.Image = Properties.Resources.마법사오른쪽스텐딩; // 원래 이미지로 변경
                magician2.Image = Properties.Resources.마법사오른쪽스텐딩; // 원래 이미지로 변경
                monster.Image = Properties.Resources.불몬스터왼쪽스텐딩_;
                monster1.Image = Properties.Resources.몬스터왼쪽스텐딩;
                leftlabel.Visible = false;
                rightlabel.Visible = false;
                Bolt.Visible = false;
                Bolt2.Visible = false;
            }
            else
            {
                magician.Image = Properties.Resources.마법사오른쪽빔; // 물 이미지로 변경
                magician2.Image = Properties.Resources.불마법사오른쪽빔; // 불 이미지로 변경
                monster.Image = Properties.Resources.불몬스터왼쪽타격;
                monster1.Image = Properties.Resources.몬스터왼쪽죽음;

                leftlabel.Visible = true;
                rightlabel.Visible = true;
                Bolt.Visible = true;
                Bolt2.Visible = true;

            }

            isAImageShown = !isAImageShown;
        }
    }
}
