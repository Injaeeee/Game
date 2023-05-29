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

        private Timer rockTimer; // 돌이 떨어지는 타이머
        private Random random2; // 돌 랜덤

        private int bossClickCounter; // 보스 클릭 카운터 변수

        public BossMode()
        {
            InitializeComponent();
            InitializeMovement();
            random = new Random();//보스의 랜덤움직임을 나타내기위해

            random2 = new Random(); //돌의 랜덤
            rockTimer = new Timer();
            rockTimer.Interval = 2000; // 2초마다 타이머 이벤트 발생
            rockTimer.Tick += RockTimer_Tick; // 돌이 떨어지는 동작을 처리하는 이벤트 핸들러 연결
            rockTimer.Start(); // 타이머 시작
        }
        private void InitializeMovement()
        {
            this.MouseMove += BossMode_MouseMove;

        }

        private void RockTimer_Tick(object sender, EventArgs e)
        {
            // 돌이 떨어지는 동작을 구현합니다.
            int rockCount = random2.Next(3, 6); // 3개에서 5개 사이의 돌을 랜덤으로 생성

            for (int i = 0; i < rockCount; i++)
            {
                int x = random.Next(0, this.Width - 50); // 돌의 x 좌표를 랜덤으로 설정
                int y = -50 - i * 50; // 돌의 초기 y 좌표 (화면 위쪽에서 시작하되, 각 돌은 50픽셀씩 위로 이동하여 겹치지 않게 설정)
                PictureBox rock = new PictureBox();
                rock.Image = Properties.Resources.Icon_Skull; // 돌 이미지 설정
                rock.SizeMode = PictureBoxSizeMode.StretchImage;
                rock.Size = new Size(50, 50);
                rock.Location = new Point(x, y);
                rock.BringToFront(); // 돌 이미지가 다른 요소 위로 올라가도록 설정
                Boss.SendToBack();
                this.Controls.Add(rock); // 돌을 폼에 추가

                // 돌이 아래로 이동하는 애니메이션
                Timer rockAnimationTimer = new Timer();
                rockAnimationTimer.Interval = 10; // 10밀리초마다 타이머 이벤트 발생
                rockAnimationTimer.Tick += (s, ev) =>
                {
                    rock.Top += 5; // 돌을 아래로 5픽셀씩 이동

                    if (rock.Top >= this.Height) // 돌이 폼의 바닥에 도달하면 타이머 중지
                    {
                        rockAnimationTimer.Stop(); // 타이머 중지
                        this.Controls.Remove(rock); // 돌을 폼에서 제거
                        rock.Dispose(); // 돌에 사용된 리소스 해제
                    }
                };
                rockAnimationTimer.Start(); // 타이머 시작
            }
        }


        private void Boss_Click(object sender, EventArgs e)
        {
            if (isBossClicked)
                return; // 이미 보스가 클릭된 상태면 무시

            isBossClicked = true; // 보스 클릭 상태로 설정
                                   
            Boss.Image = Properties.Resources.보스피격;

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


            // 클릭 횟수 증가
            bossClickCounter++;

            // 보스를 10번 클릭하면 사라지게 함
            if (bossClickCounter >= 10)
            {
                Boss.Image = Properties.Resources.보스죽음; // 보스 사망 이미지

                Task.Delay(1000).ContinueWith(_ =>
                {
                    this.Invoke((MethodInvoker)(() =>
                    {

           
                        this.Controls.Remove(Boss); // 보스를 폼에서 제거
                        Boss.Dispose(); // 보스에 할당된 리소스 해제
                    }));
                });
                return;
            }
            else
            {
                Task.Delay(1000).ContinueWith(_ =>
                {
                    this.Invoke((MethodInvoker)(() =>
                    {
                        Boss.Image = Properties.Resources.Boss반전; // 원래 보스 이미지로 되돌리기
                        isBossClicked = false; // 보스 클릭 상태 초기화
                    }));
                });


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

        private void BossMode_Load(object sender, EventArgs e)
        {

        }
    }

}
