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

        bool soundcheck = true;
        private int timeLimit;
        private Timer timer;
        private int monsterCount = 5; // 각 몬스터의 클릭 횟수
        private int clickedMonsters = 0; // 클릭한 몬스터 수
        private List<PictureBox> monsters = new List<PictureBox>(); // 몬스터들을 담을 리스트
        private Random random = new Random(); // 랜덤 숫자 생성을 위한 인스턴스


        public GameForm()
        {
            InitializeComponent();
            init();
          
            gamePlay();

            timeLimit = 100; // 시간 제한 설정 (초 단위)
            timer = new Timer();
            timer.Interval = 1000; // 1초마다 타이머 이벤트 발생
            timer.Tick += Gametimer_Tick;


        }


        public void init()
        {
            
        }

 

        private void mousePosition()
        {
            label1.Text = Cursor.Position.X.ToString();
            label2.Text = Cursor.Position.Y.ToString();
        }

        private void gamePlay()
        {

            for (int i = 0; i < monsterCount; i++)
            {
                PictureBox monster = new PictureBox();
                monster.Image = Properties.Resources.몬스터왼쪽스텐딩; // 몬스터 이미지 설정
                monster.SizeMode = PictureBoxSizeMode.StretchImage; // 이미지 크기 조절 옵션
                monster.Width = 109;
                monster.Height = 119;
                monster.BackColor = Color.Transparent;
                monster.Left = random.Next(0, this.Width - monster.Width); // 랜덤한 X 좌표
                monster.Top = 467; // 바닥에 고정된 Y 좌표
                monster.Click += Monster_Click; // 몬스터 클릭 이벤트 핸들러 연결
                monster.Tag = 0; // 클릭 횟수 초기화


                monsters.Add(monster); // 생성한 몬스터를 리스트에 추가
                this.Controls.Add(monster); // 몬스터를 Form에 추가하여 보이도록 설정
            }




        }

        private void GameForm_MouseMove(object sender, MouseEventArgs e)
        {
            //mouseX = e.Location.X;
            //mouseY = e.Location.Y;
            label1.Text = e.Location.X.ToString();
            label2.Text = e.Location.Y.ToString();

            if (Cursor.Position.X > 900)
            {
                magician.Image = Properties.Resources.마법사오른쪽스텐딩;
                if(Cursor.Position.X > 1100)
                    magician.Image = Properties.Resources.마법사오른쪽걷기;


            }
            else
            {
                magician.Image = Properties.Resources.마법사왼쪽스텐딩;
                if(Cursor.Position.X < 600)
                    magician.Image = Properties.Resources.마법사왼쪽걷기;
            }

            RightLaser.Visible = false;
            leftlaser.Visible = false;
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            RightLaser.Visible = false;
            leftlaser.Visible = false;
            timer.Start(); // 타이머 시작
            timeLabel.Text = "Time: " + timeLimit.ToString();
            leftlaser.SendToBack(); // 왼쪽 레이저를 최하위로 가져옴
            RightLaser.SendToBack(); // 오른쪽 레이저를 최하위로 가져옴 - 몬스터보다 레이저가 뒤로 가야함
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

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            MenuForm showForm = new MenuForm();
            this.Hide();
            showForm.ShowDialog();


        }

        private void Monster_Click(object sender, EventArgs e)
        {
            if (Cursor.Position.X > 880)
            {
                magician.Image = Properties.Resources.마법사오른쪽빔;
                RightLaser.Visible = true;
       
            }
            else
            {
                magician.Image = Properties.Resources.마법사왼쪽빔;
                leftlaser.Visible = true;
            }

            PictureBox monster = (PictureBox)sender;
            int currentClicks = int.Parse(monster.Tag.ToString()); // 현재 몬스터의 클릭 횟수를 가져옴
            currentClicks++; // 클릭 횟수 증가
            monster.Tag = currentClicks; // 증가된 클릭 횟수를 다시 저장

            if (currentClicks >= monsterCount) // 몬스터의 클릭 횟수가 지정된 횟수 이상일 경우
            {
                monster.Visible = false; // 몬스터를 화면에서 숨김
                clickedMonsters++; // 클릭한 몬스터 수 증가

                if (clickedMonsters == monsters.Count) // 모든 몬스터를 클릭하여 없앴을 경우
                {
                    timer.Stop(); // 타이머 정지
                    MessageBox.Show("모든 몬스터를 처치했습니다!");
                    // 게임 클리어 시 동작을 추가로 구현하면 됩니다.
                }
            }
        }

        private void Gametimer_Tick(object sender, EventArgs e)
        {
            timeLimit--; // 시간 감소
            timeLabel.Text = "Time: " + timeLimit.ToString();

            if (timeLimit == 0) // 시간 종료 시 게임 종료
            {
                timer.Stop(); // 타이머 정지
                MessageBox.Show("최종 보스 등장!");
                // 이 다음 폼을 새로 열까 ? ..
            }
        }


    }
}
