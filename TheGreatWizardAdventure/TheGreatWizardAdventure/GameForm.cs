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
        }

        public class Player : Charactor
        {
            public static Player player = new Player
            {
                x = 0,
                y = 0,
                speed = 0,
                isMove = false,
                direction = "none"
            };

            public static void UpdatePlayerPosition(int x, int y)
            {
                player.x = x;
                player.y = y;
            }
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

        //================================================================================================================








        //================================================================================================================


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
        }
    }
}
