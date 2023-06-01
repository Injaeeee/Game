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
    public partial class _6 : UserControl
    {

        private int floatingDirection = 1; // 1: 위로, -1: 아래로
        private int floatingSpeed = 1; // 둥둥 떠다니는 속도

        public _6()
        {
            InitializeComponent();
            InitializeFloatingAnimation();
        }

        private void InitializeFloatingAnimation()
        {
            floatingTimer = new Timer();
            floatingTimer.Interval = 1; // 애니메이션 속도 조절
            floatingTimer.Tick += floatingTimer_Tick;
            floatingTimer.Start();
        }

        private void floatingTimer_Tick(object sender, EventArgs e)
        {
            int minY = 135; // 마법사가 이동할 수 있는 최소 Y 위치
            int maxY = 170; // 마법사가 이동할 수 있는 최대 Y 위치

            // 현재 위치를 가져옴
            int currentY = magician.Location.Y;

            // 이동할 다음 위치 계산
            int nextY = currentY + (floatingDirection * floatingSpeed);

            // 다음 위치가 최소 또는 최대 위치를 벗어나면 방향을 바꿔줌
            if (nextY < minY || nextY > maxY)
            {
                floatingDirection *= -1; // 방향 전환
                nextY = currentY + (floatingDirection * floatingSpeed); // 다음 위치 재계산
            }

            // 마법사 픽쳐박스의 위치 업데이트
            magician.Location = new Point(magician.Location.X, nextY);
        }
    
    }
}
