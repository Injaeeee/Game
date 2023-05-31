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

    public partial class StartGuideForm : Form
    {
        private int magicianXPosition;
        private int bossXPosition = 1200;
        private List<PictureBox> monsters; // 몬스터 PictureBox들을 저장할 리스트 변수 추가


        public StartGuideForm()
        {
            InitializeComponent();
            InitializeAnimation();
            monsters = new List<PictureBox>(); // 몬스터 PictureBox들을 저장할 리스트 초기화
        }

        private void InitializeAnimation()
        {
            mark.Visible = false;
            mark2.Visible = false;
            Laser.Visible = false;
            // Timer 설정
            animationTimer = new Timer();
            animationTimer.Interval = 10; // 애니메이션 속도 조절
            animationTimer.Tick += animationTimer_Tick;

            BossAttack = new Timer();
            BossAttack.Interval = 1000; // 1초 설정
            BossAttack.Tick += BossAttack_Tick;

            animationTimer.Start();
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            // 마법사 PictureBox의 x축 위치 변경
            magicianXPosition += 3; // 이동 거리를 조정
            magician.Location = new Point(magicianXPosition, 258);

            // 보스 PictureBox의 x축 위치 변경
            bossXPosition -= 2;
            Boss.Location = new Point(bossXPosition, Boss.Location.Y);

            // 마법사 PictureBox가 일정 거리에 도달하면 애니메이션을 멈춤
            if (magicianXPosition >= 400)
            {
                mark.Visible = true;
                mark2.Visible = true;
                animationTimer.Stop();
                magician.Image = Properties.Resources.마법사오른쪽스텐딩;
                BossAttack.Start();
            }
        }

        private void BossAttack_Tick(object sender, EventArgs e)
        {
            mark.Visible = false;
            mark2.Visible = false;

            Boss.Image = Properties.Resources.보스시비;
            Boss.SizeMode = PictureBoxSizeMode.StretchImage;
            Boss.Size = new Size(Boss.Size.Width + 10, Boss.Size.Height + 10); // 크기 증가


            magician.Image = Properties.Resources.마법사오른쪽빔;
            Laser.Visible = true;
            BossAttack.Stop(); // hideTimer 정지


            int monsterCount = 5; // 등장할 몬스터 수
            int monsterSize = 70; // 몬스터의 가로 크기
            int monsterSpacing = 10; // 몬스터 사이의 간격
            int monsterSpeed = 5; // 몬스터 이동 속도

            int initialX = this.ClientSize.Width; // 초기 몬스터 위치: 폼 오른쪽
            int initialY = Boss.Location.Y + Boss.Size.Height + monsterSpacing; // 몬스터의 초기 y 위치

            for (int i = 0; i < monsterCount; i++)
            {
                PictureBox monster = new PictureBox();
                monster.Image = Properties.Resources.몬스터왼쪽걷기; // 몬스터 이미지 설정
                monster.SizeMode = PictureBoxSizeMode.StretchImage;
                monster.Size = new Size(monsterSize, monsterSize);

                int monsterX = initialX + (monsterSize + monsterSpacing) * i; // 몬스터의 초기 x 위치
                int monsterY = initialY;
                monster.Location = new Point(monsterX, monsterY);

                // 배경을 투명하게 설정
                monster.BackColor = Color.Transparent;
                monster.Parent = this;

                Controls.Add(monster); // 몬스터를 화면에 추가
                monsters.Add(monster); // 몬스터를 리스트에 저장
            }

            // 몬스터 이동을 처리하기 위한 Timer 설정
            moveMonstersTimer = new Timer();
            moveMonstersTimer.Interval = 10; // 이동 속도 조절
            moveMonstersTimer.Tick += moveMonstersTimer_Tick;
            moveMonstersTimer.Start();
        }

        private void moveMonstersTimer_Tick(object sender, EventArgs e)
        {
            int monsterSpeed = 5; // 몬스터 이동 속도

            // 모든 몬스터들을 오른쪽으로 이동시킴
            foreach (PictureBox monster in monsters)
            {
                monster.Left -= monsterSpeed; // 오른쪽으로 이동

                // 몬스터가 보스의 아래로 도달하면 Timer 정지
                if (monster.Right < Boss.Left)
                {
                    moveMonstersTimer.Stop();
                    SkipButton.Visible = true;
                    foreach (PictureBox m in monsters)
                    {
                        m.Image = Properties.Resources.몬스터왼쪽스텐딩; // 모든 몬스터 이미지 설정
                    }

                }
            }
        }

        private void SkipButton_Click(object sender, EventArgs e)
        {

            BossMode showFrom = new BossMode();
            this.Hide();
            showFrom.ShowDialog();
        }

        private void StartGuideForm_Load(object sender, EventArgs e)
        {

            SkipButton.Visible = false;
        }
    }

}
