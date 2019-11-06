using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Media;
using System.Windows;

namespace ElevatorEmulator
{
    class OpenForm : Form
    {
        private Rectangle elevator;
        private Rectangle elevatorContainer;

        private int elevatorHeight;
        private const int ELEVATOR_CONTAINER_HEIGHT = 600;
        private const int ELEVATOR_SIZE_X = 90;
        private const int ELEVATOR_SIZE_Y = 100;
        private const int ELEVATOR_CONTAINER_LOCATION_X = 300;
        private const int ELEVATOR_CONTAINER_LOCATION_Y = 10;
        private const int DISTANCE_BETWEEN_FLOOR = 10;

        public Rectangle Elevator { get => elevator; set => elevator = value; }
        public Rectangle ElevatorContainer { get => elevatorContainer; set => elevatorContainer = value; }
        public int ElevatorHeight { get => elevatorHeight; set => elevatorHeight = value; }

        public OpenForm()
        {
            elevator = new Rectangle();
            elevator.Location = new Point(ELEVATOR_CONTAINER_LOCATION_X, 0 * ELEVATOR_CONTAINER_HEIGHT + ELEVATOR_CONTAINER_LOCATION_Y);
            elevator.Size = new Size(ELEVATOR_SIZE_X, ELEVATOR_SIZE_Y);
            

            elevatorContainer = new Rectangle();
            elevatorContainer.Location = new Point(ELEVATOR_CONTAINER_LOCATION_X, ELEVATOR_CONTAINER_LOCATION_Y);
            elevatorContainer.Size = new Size(ELEVATOR_SIZE_X, ELEVATOR_CONTAINER_HEIGHT);

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // OpenForm
            // 
            this.ClientSize = new System.Drawing.Size(612, 423);
            this.Name = "OpenForm";
            this.ResumeLayout(false);

        }
    }
}
