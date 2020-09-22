using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Aquarium
{
    class Fish { 
        public int WIDTH = 1500;
        public int HEIGHT = 900;
        public int SIZE = 10;
        public int LEFT_MENU = 200;

        Form1 form;
        int posX;
        int posY;
        public string Id { get; private set; }
        public PictureBox FCell { get; private set; }
        public int PosX {
            get
            {
                return posX;
            }
            set
            {
                posX = posX + value * SIZE;
                //form = new Form1();
                //form.Controls.Clear();
                FCell.Dispose();
                PictureBox fishBox = new PictureBox();
                fishBox.BackColor = Color.Red;
                fishBox.Name = "pred" + Convert.ToString(0);
                fishBox.Size = new Size(SIZE, SIZE);

                fishBox.Location = new Point(posX, posY);
                FCell = fishBox;
            }
        }
        public int PosY {
            get
            {
                return posY;
            }
            set
            {
                posY = posY + value * SIZE;
                FCell.Location = new Point(posX, posY);
            }
        }


        public Fish (PictureBox fCell, int posX, int posY)
        {
            Id = fCell.Name;
            FCell = fCell;
            this.posX = posX;
            this.posY = posY;
        }

        public Fish()
        {

        }

        public void getRandomPos(Fish fish)
        {
            Random rand = new Random();
            int step = rand.Next(1, 5);

            if (step == 1)
            {//Вверх
                fish.PosY = -1;
            }
            else if (step == 2)
            {//направо
                fish.PosX = +1;
            }
            else if (step == 3)
            {//вниз
                fish.PosY = +1;
            }
            else if (step == 4)
            {//налево
                fish.PosX = -1;
            }
        }
    }
}
