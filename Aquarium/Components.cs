using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Aquarium
{
    class Components
    {
        public int WIDTH = 1500;
        public int HEIGHT = 900;
        public int SIZE = 10;
        public int LEFT_MENU = 200;

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
    }
}
