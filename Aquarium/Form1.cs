using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aquarium
{
    public partial class Form1 : Form
    {
        public int WIDTH = 1500;
        public int HEIGHT = 900;
        public int SIZE = 10;
        public int LEFT_MENU = 200;

        List<Fish> FishArr = new List<Fish>();

        public Form1()
        {
            InitializeComponent();

            this.Width = WIDTH + 17 + LEFT_MENU;
            this.Height = HEIGHT + 40;
            leftMenu.Height = Height;
            leftMenu.Width = LEFT_MENU; 

            generateMap();
            generateCreatures(1, 0);

            timer.Tick += new EventHandler(update);
            timer.Interval = 1000;
            timer.Start();

            //Fish fish = new Fish();
        }

        public void generateMap()
        {
            for (int i = 0; i <= HEIGHT / SIZE; i++)
            {
                PictureBox pb = new PictureBox();
                pb.BackColor = Color.FromArgb(0, 153, 199);
                pb.Location = new Point(LEFT_MENU, SIZE * i);
                pb.Size = new Size(WIDTH, 1);
                this.Controls.Add(pb);
            }

            for (int i = 0; i <= WIDTH / SIZE; i++)
            {
                PictureBox pb = new PictureBox();
                pb.BackColor = Color.FromArgb(0, 153, 199);
                pb.Location = new Point(SIZE * i + LEFT_MENU, 0);
                pb.Size = new Size(1, HEIGHT);
                this.Controls.Add(pb);
            }

        }

        public List<PictureBox> generateFishBox(string fishType, int count)
        {
            List<PictureBox> fishBoxArr = new List<PictureBox>();
            Color fishColor = Color.Gray;

            if (fishType == "pred")
            {
                fishColor = Color.Red;
            }
            else if (fishType == "herb")
            {
                fishColor = Color.Green;
            }

            for (int i = 0; i < count; i++)
            {
                PictureBox fishBox = new PictureBox();
                fishBox.BackColor = fishColor;
                fishBox.Name = fishType + Convert.ToString(i);
                fishBox.Size = new Size(SIZE, SIZE);
                fishBoxArr.Add(fishBox);
            }

            return fishBoxArr;
        }

        public void generateCreatures(int predFishCount = 5, int herbFishCount = 5)
        {
            List<PictureBox> predFishBoxArr = generateFishBox("pred", predFishCount);
            List<PictureBox> herbFishBoxArr = generateFishBox("herb", herbFishCount);

            int i = 0;
            foreach (PictureBox element in predFishBoxArr)
            {
                int posX = LEFT_MENU + i * SIZE + 500;
                int posY = 0 * SIZE + 500;
                element.Location = new Point(posX, posY);
                this.Controls.Add(element);
                Fish fish = new Fish(element, posX, posY);
                FishArr.Add(fish);
                i++;
            }

            i = 0;
            foreach (PictureBox element in herbFishBoxArr)
            {
                int posX = LEFT_MENU + i * SIZE + 500;
                int posY = 1 * SIZE + 500;
                element.Location = new Point(posX, posY);
                this.Controls.Add(element);
                Fish fish = new Fish(element, posX, posY);
                FishArr.Add(fish);
                i++;
            }
        }

        private void update(Object myObject, EventArgs eventArgs)
        {
            //for (int i = 0; i < FishArr.Count; i++)
            //{
                Fish fish = FishArr[0];
                //fish.getRandomPos(fish);
            fish.PosX = 1;
            //}
        }
    }
}
