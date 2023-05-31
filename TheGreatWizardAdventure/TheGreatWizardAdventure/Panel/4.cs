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
    public partial class _4 : UserControl
    {
        private const int ProgressBarMaxValue = 10;
        private const int ProgressBarDecreaseAmount = 1;
        private const int ProgressBarInterval = 1000; // 2초

        private bool isProgressBarDecreasing;

        public _4()
        {
            InitializeComponent();
            InitializeProgressBar();
        }
        private void InitializeProgressBar()
        {
            bossHealthBar.Minimum = 0;
            bossHealthBar.Maximum = ProgressBarMaxValue;
            bossHealthBar.Value = ProgressBarMaxValue;

            progressBarTimer = new Timer();
            progressBarTimer.Interval = ProgressBarInterval;
            progressBarTimer.Tick += progressBarTimer_Tick;
            progressBarTimer.Start();
        }

        private void _4_Load(object sender, EventArgs e)
        {
            Clicklabel.Visible = false;
        }

        private void progressBarTimer_Tick(object sender, EventArgs e)
        {
            if (isProgressBarDecreasing)
            {
                if (bossHealthBar.Value > 0)
                {
                    bossHealthBar.Value -= ProgressBarDecreaseAmount;
                    magician.Image = Properties.Resources.마법사오른쪽빔;
                    Boss.Image = Properties.Resources.보스피격;

                    Clicklabel.Visible = true;
                }
                else
                {
                    magician.Image = Properties.Resources.마법사오른쪽스텐딩;
                    Boss.Image = Properties.Resources.Boss반전;
                    bossHealthBar.Value = ProgressBarMaxValue;
                    Clicklabel.Visible = false;
                }
            }
            else
            {
                magician.Image = Properties.Resources.마법사오른쪽스텐딩;
                Boss.Image = Properties.Resources.Boss반전;
                Clicklabel.Visible = false;
            }
            isProgressBarDecreasing = !isProgressBarDecreasing;
        }
    }
}
