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
    public partial class _2 : UserControl
    {
        private int magicianXPosition;
        private bool isMovingLeft;
        public _2()
        {
            InitializeComponent();
            InitializeAnimation();
        }
        private void InitializeAnimation()
        {

            isMovingLeft = true;

            animationTimer = new Timer();
            animationTimer.Interval = 10; // 애니메이션 속도 조절
            animationTimer.Tick += animationTimer_Tick;

            animationTimer.Start();
        }
        private void animationTimer_Tick(object sender, EventArgs e)
        {
            const int moveSpeed = 5; // 이동 속도

            if (isMovingLeft)
            {
                // 좌로 이동
                if (magicianXPosition > -500)
                {
                    magicianXPosition -= moveSpeed;
                    magician.Location = new Point(magicianXPosition, magician.Location.Y);
                }
                // 좌로 이동이 완료되면 이동 방향을 우측으로 변경
                else
                {
                    isMovingLeft = false;
                }
            }
            else
            {
                // 우로 이동
                if (magicianXPosition < 0)
                {
                    magicianXPosition += moveSpeed;
                    magician.Location = new Point(magicianXPosition, magician.Location.Y);
                }
                // 우로 이동이 완료되면 애니메이션을 멈춤
                else
                {
                    animationTimer.Stop();
                }
            }
        }
    }
}
