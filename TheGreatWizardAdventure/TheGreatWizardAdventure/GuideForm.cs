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

    public partial class GuideForm : Form
    {
        public static int check_click = 1;
        Panel._1 UcSc1 = new Panel._1();
        Panel._2 UcSc2 = new Panel._2();
        Panel._3 UcSc3 = new Panel._3();
        Panel._4 UcSc4 = new Panel._4();
        Panel._5 UcSc5 = new Panel._5();
        Panel._6 UcSc6 = new Panel._6();

        public GuideForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (check_click < 8)
            {
                check_click++;

                if (check_click == 1)
                {
                    Guidepanel.Controls.Clear();
                    Guidepanel.Controls.Add(UcSc1);

                }
                else if (check_click == 2)
                {
                    Guidepanel.Controls.Clear();
                    Guidepanel.Controls.Add(UcSc2);

                    NextButton.Visible = true;
                    StartButton.Visible = true;
                    BackButton.Visible = true;
                }
                else if (check_click == 3)
                {
                    Guidepanel.Controls.Clear();
                    Guidepanel.Controls.Add(UcSc3);
                }
                else if (check_click == 4)
                {
                    Guidepanel.Controls.Clear();
                    Guidepanel.Controls.Add(UcSc4);
                }
                else if (check_click == 5)
                {
                    Guidepanel.Controls.Clear();
                    Guidepanel.Controls.Add(UcSc5);
                }
                else if (check_click == 6)
                {
                    Guidepanel.Controls.Clear();
                    Guidepanel.Controls.Add(UcSc6);
                    NextButton.Visible = false;

                }

            }


        }

        private void GuideForm_Load(object sender, EventArgs e)
        {
            Guidepanel.Controls.Clear();
            Guidepanel.Controls.Add(UcSc1);
            NextButton.Visible = true;
            StartButton.Visible = true;
            BackButton.Visible = false;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (check_click > 1)
            {
                --check_click;

                if (check_click == 1)
                {
                    Guidepanel.Controls.Clear();
                    Guidepanel.Controls.Add(UcSc1);
                    BackButton.Visible = false;
                }
                else if (check_click == 2)
                {
                    Guidepanel.Controls.Clear();
                    Guidepanel.Controls.Add(UcSc2);
                }
                else if (check_click == 3)
                {
                    Guidepanel.Controls.Clear();
                    Guidepanel.Controls.Add(UcSc3);
                }
                else if (check_click == 4)
                {
                    Guidepanel.Controls.Clear();
                    Guidepanel.Controls.Add(UcSc4);
                }
                else if (check_click == 5)
                {
                    Guidepanel.Controls.Clear();
                    Guidepanel.Controls.Add(UcSc5);
                    NextButton.Visible = true;
                }
                else if (check_click == 6)
                {
                    Guidepanel.Controls.Clear();
                    Guidepanel.Controls.Add(UcSc6);

                }
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {


            StartGuideForm showForm = new StartGuideForm();
            this.Hide();
            showForm.ShowDialog();
        }
    }
}
