using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TheGreatWizardAdventure.Container.GameForm;

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

        // layer size 620 * 360
        Image layer_1 = Properties.Resources.flayer_1;
        Image layer_2 = Properties.Resources.flayer_2;
        Image layer_3 = Properties.Resources.flayer_4;

        int b1 = 0, b2 = 600, b3 = 1200, b4 = 1800, x1 = 0, x2 = 600, x3 = 1200, x4 = 1800, g1 = 0, g2 = 600, g3 = 1200, g4 = 1800;

        public class Charactor
        {
            public int x;
            public int y;
            public int speed;
            public bool isMove;
            public String direction;
            public int HP;
        }

        public class Player : Charactor
        {
            public static Player player = new Player
            {
                x = 0,
                y = 0,
                speed = 0,
                isMove = false,
                direction = "none",
                HP = 3
            };

            public static void UpdatePlayerPosition(int x, int y)
            {
                player.x = x;
                player.y = y;
            }

            //public void RepaintHP(int HP)
            //{
            //   // 현재 HP 번의 하트의 상태를 변경해주면 되잖아

            //}
        }

        public class Monster : Charactor
        {

        }

        static public class Mouse
        {
            public static int MouseX { get; private set; }
            public static int MouseY { get; private set; }

            public static void UpdateMousePosition(int x, int y)
            {
                MouseX = x;
                MouseY = y;
            }
        }

        public GameForm()
        {
            InitializeComponent();

            GenerateMonster();
            timeLimit = 100; // 시간 제한 설정 (초 단위)
            timer = new Timer();
            timer.Interval = 1000; // 1초마다 타이머 이벤트 발생
            timer.Tick += Gametimer_Tick;
        }

        private void GameForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(layer_1, b1, 0);
            e.Graphics.DrawImage(layer_1, b2, 0);
            e.Graphics.DrawImage(layer_1, b3, 0);
            e.Graphics.DrawImage(layer_1, b4, 0);
            e.Graphics.DrawImage(layer_2, x1, 0);
            e.Graphics.DrawImage(layer_2, x2, 0);
            e.Graphics.DrawImage(layer_2, x3, 0);
            e.Graphics.DrawImage(layer_2, x4, 0);
            e.Graphics.DrawImage(layer_3, g1, 0);
            e.Graphics.DrawImage(layer_3, g2, 0);
            e.Graphics.DrawImage(layer_3, g3, 0);
            e.Graphics.DrawImage(layer_3, g4, 0);
        }
        
        public void PlayerDirection(Player player, int x)
        {
            if (player.x < x)
            {
                player.direction = "right";
            }
            else if (player.x > x)
            {
                player.direction = "left";
            }
            else
            {
                player.direction = "none";
            }
        }

        public void BackgroundMove(Player player)
        {
            // layer_1 움직임
            b1 = MoveBackgroundLayer(b1, player.direction, 2);
            b2 = MoveBackgroundLayer(b2, player.direction, 2);
            b3 = MoveBackgroundLayer(b3, player.direction, 2);
            b4 = MoveBackgroundLayer(b4, player.direction, 2);

            // layer_2 움직임
            x1 = MoveBackgroundLayer(x1, player.direction, 4);
            x2 = MoveBackgroundLayer(x2, player.direction, 4);
            x3 = MoveBackgroundLayer(x3, player.direction, 4);
            x4 = MoveBackgroundLayer(x4, player.direction, 4);

            // layer_3 움직임
            g1 = MoveBackgroundLayer(g1, player.direction, 5);
            g2 = MoveBackgroundLayer(g2, player.direction, 5);
            g3 = MoveBackgroundLayer(g3, player.direction, 5);
            g4 = MoveBackgroundLayer(g4, player.direction, 5);

            Invalidate();
        }

        private int MoveBackgroundLayer(int position, string direction, int speed)
        {
            if (position < -620)
            {
                position = 1800;
            }
            if (position > 1800)
            {
                position = -620;
            }

            if (direction == "right")
            {
                position -= speed;
            }
            else if (direction == "left")
            {
                position += speed;
            }

            return position;
        }

        private void BackgroundTimer_Tick(object sender, EventArgs e)
        {
            BackgroundMove(Player.player);
        }

        private void RepaintHP(Charactor charactor)
        {
            string n = charactor.HP.ToString();
            n = "Heart" + n;

            for (int i = 1; i <= charactor.HP; i++)
            {
                string heartControlName = "Heart" + i.ToString();
                PictureBox heartPictureBox = Controls.Find(heartControlName, true).FirstOrDefault() as PictureBox;

                if (heartPictureBox != null)
                {
                    heartPictureBox.Image = Properties.Resources.full_heart;
                }
            }

            // 남은 하트를 투명하게 그리기
            for (int i = charactor.HP + 1; i <= 3; i++)
            {
                string heartControlName = "Heart" + i.ToString();
                PictureBox heartPictureBox = Controls.Find(heartControlName, true).FirstOrDefault() as PictureBox;

                if (heartPictureBox != null)
                {
                    heartPictureBox.Image = Properties.Resources.empty_heart;
                }
            }
        }

        //================================================================================================================












        //================================================================================================================

        private void GenerateMonster()
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
                monster.Top = 367; // 바닥에 고정된 Y 좌표
                monster.Click += Monster_Click; // 몬스터 클릭 이벤트 핸들러 연결
                monster.Tag = 0; // 클릭 횟수 초기화

                monsters.Add(monster); // 생성한 몬스터를 리스트에 추가
                this.Controls.Add(monster); // 몬스터를 Form에 추가하여 보이도록 설정
            }
        }
        private void GameForm_MouseMove(object sender, MouseEventArgs e)
        {
            Mouse.UpdateMousePosition(e.Location.X, e.Location.Y);
            Player.UpdatePlayerPosition(magician.Location.X, magician.Location.Y);
            PlayerDirection(Player.player, e.Location.X);
            label1.Text = e.Location.X.ToString();
            label2.Text = e.Location.Y.ToString();
            label3.Text = Player.player.direction;

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
