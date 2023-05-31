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

        private const int MovementDistance = 200; // 이동 거리
        private const int MovementDuration = 2000; // 이동 시간 (2초)

        private bool isMovingLeft;

        private int startPosition;
        private int targetPosition;
        private int currentDuration;
        private int animationSteps;
        public _2()
        {
            InitializeComponent();
            InitializeMovement();

        }

        private void InitializeMovement()
        {
            moveTimer = new Timer();
            moveTimer.Interval = MovementDuration / 100; // 이동 간격 조정
            moveTimer.Tick += moveTimer_Tick;

            isMovingLeft = true; // 왼쪽으로 이동 시작
            startPosition = magician.Left;
            targetPosition = startPosition - MovementDistance;
            currentDuration = 0;
            animationSteps = 100;

            moveTimer.Start();

        }

        private void moveTimer_Tick(object sender, EventArgs e)
        {
            currentDuration++;

            double progress = (double)currentDuration / animationSteps;
            double interpolation = Math.Pow(progress, 2); // 부드러운 이동을 위해 제곱 함수 사용

            int currentStep = (int)(interpolation * MovementDistance);

            if (isMovingLeft)
            {
                // 왼쪽으로 이동
                magician.Left = startPosition - currentStep;
                LEFTMOUSE.Visible = true;
                RIGHTMOUSE.Visible = false;
                magician.Image = Properties.Resources.마법사왼쪽걷기;
            }
            else
            {
                // 오른쪽으로 이동
                magician.Left = startPosition + currentStep;
                LEFTMOUSE.Visible = false;
                RIGHTMOUSE.Visible = true;
                magician.Image = Properties.Resources.마법사오른쪽걷기;
            }

            if (currentDuration >= animationSteps)
            {
                currentDuration = 0;
                isMovingLeft = !isMovingLeft; // 이동 방향을 반전시킴

                // 이동 방향을 반전시킨 후 바로 다음 방향으로 이동
                if (isMovingLeft)
                {
                    startPosition = magician.Left; // 왼쪽으로 이동한 위치를 시작 위치로 설정
                    targetPosition = startPosition - MovementDistance; // 왼쪽으로 이동하기 위한 목표 위치 설정
                }
                else
                {
                    startPosition = magician.Left; // 오른쪽으로 이동한 위치를 시작 위치로 설정
                    targetPosition = startPosition + MovementDistance; // 오른쪽으로 이동하기 위한 목표 위치 설정
                }
            }
        }
    }
    }
