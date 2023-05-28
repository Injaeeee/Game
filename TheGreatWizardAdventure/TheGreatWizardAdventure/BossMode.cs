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
        bool soundcheck = true; // 음향사운드 온오프
        private bool isMoving; //캐릭터가 움직이는지 확인
        private bool isBossClicked; // 보스를 클릭했는지 확인

        private Random random; // 랜덤 객체 생성

        private int bossMoveDistance = 10; // 보스 이동 거리 설정
        private bool isMovingLeft; // 보스가 왼쪽으로 이동 중인지 확인


        public BossMode()
        {
            InitializeComponent();
            InitializeMovement();
            random = new Random();//보스의 랜덤움직임을 나타내기위해
        }
        private void InitializeMovement()
        {
            this.MouseMove += BossMode_MouseMove;

        }



        private void Boss_Click(object sender, EventArgs e)
        {
            isBossClicked = true; // 보스 클릭 상태로 설정

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
            // 보스의 랜덤한 움직임 설정
            int randomMove = random.Next(0, 4); // 0부터 3까지의 난수 생성

            switch (randomMove)
            {
                case 0:
                    MoveBossLeft();
                    break;
                case 1:
                    MoveBossRight();
                    break;
                case 2:
                    MoveBossUp();
                    break;
                case 3:
                    MoveBossDown();
                    break;
            }
        }



        private void CloseButton_Click(object sender, EventArgs e)
        {
            MenuForm showForm = new MenuForm();
            this.Hide();
            showForm.ShowDialog();
        }

        private void BossMode_MouseMove(object sender, MouseEventArgs e)
        {
            isMoving = true; // 이동 시작
            movementTimer.Start(); // 타이머 시작
        }

        private void MoveCharacterLeft()
        {
            int newX = magician.Location.X - 10; // 왼쪽으로 이동할 거리를 조정
            if (newX >= 0)
            {
                magician.Location = new Point(newX, magician.Location.Y);
            }
        }

        private void MoveCharacterRight()
        {
            int newX = magician.Location.X + 10; // 오른쪽으로 이동할 거리를 조정
            int maxRightX = ClientRectangle.Width - magician.Width; // 이동 가능한 최대 오른쪽 X 좌표
 
            if (newX <= maxRightX)
            {
                magician.Location = new Point(newX, magician.Location.Y);
            }
        }

        private void movementTimer_Tick(object sender, EventArgs e)
        {
            // 움직임 로직을 Timer 이벤트에서 처리하도록 수정

            if (isMoving && !isBossClicked) // 캐릭터가 보스 클릭 상태가 아니라면 계속 이동
            {
                if (Cursor.Position.X > 880)
                {
                    MoveCharacterRight();
                    magician.Image = Properties.Resources.마법사오른쪽걷기;
                }
                else
                {
                    MoveCharacterLeft();
                    magician.Image = Properties.Resources.마법사왼쪽걷기;
                }
            }
            else
            {// 이동 중이 아니거나 보스를 클릭한 상태라면 캐릭터를 멈춤
                isMoving = false;
                movementTimer.Stop(); // 타이머 중지
                isBossClicked = false; // 보스 클릭 상태 초기화
            }

            if (isMoving && !isBossClicked) // 보스 클릭 상태가 아니라면 계속 이동
            {
                if (isMovingLeft)
                {
                    MoveBossLeft();
                }
                else
                {
                    MoveBossRight();
                }
            }
                // 보스의 랜덤한 움직임 설정
                int randomMove = random.Next(0, 4); // 0부터 3까지의 난수 생성

            switch (randomMove)
            {
                case 0:
                    MoveBossLeft();
                    break;
                case 1:
                    MoveBossRight();
                    break;
                case 2:
                    MoveBossUp();
                    break;
                case 3:
                    MoveBossDown();
                    break;
            }

        }
        private void MoveBossLeft()
        {
            int newX = Boss.Location.X - bossMoveDistance; // 왼쪽으로 이동할 거리를 조정
            int minLeftX = 0; // 이동 가능한 최소 왼쪽 X 좌표

            if (newX >= minLeftX)
            {
                Boss.Location = new Point(newX, Boss.Location.Y);
            }
            else
            {
                isMovingLeft = false; // 왼쪽 이동이 끝나면 오른쪽으로 이동하기 위해 상태 변경
            }
        }

        private void MoveBossRight()
        {
            int newX = Boss.Location.X + bossMoveDistance; // 오른쪽으로 이동할 거리를 조정
            int maxRightX = ClientRectangle.Width - Boss.Width; // 이동 가능한 최대 오른쪽 X 좌표

            if (newX <= maxRightX)
            {
                Boss.Location = new Point(newX, Boss.Location.Y);
            }
            else
            {
                isMovingLeft = true; // 오른쪽 이동이 끝나면 왼쪽으로 이동하기 위해 상태 변경
            }
        }


        private void MoveBossUp()
        {
            int newY = Boss.Location.Y - 10; // 위로 이동할 거리를 조정
            int minTopY = 0; // 이동 가능한 최소 위쪽 Y 좌표

            if (newY >= minTopY)
            {
                Boss.Location = new Point(Boss.Location.X, newY);
            }
        }

        private void MoveBossDown()
        {
            int newY = Boss.Location.Y + 10; // 아래로 이동할 거리를 조정
            int maxBottomY = ClientRectangle.Height - Boss.Height; // 이동 가능한 최대 아래쪽 Y 좌표

            if (newY <= maxBottomY)
            {
                Boss.Location = new Point(Boss.Location.X, newY);
            }
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
    }

}
