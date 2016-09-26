using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerrariaUSaveEditor
{
    public partial class ItemBoxGrid : UserControl
    {
        public ItemBox[][] ItemBoxes;
        public ItemBoxGrid(int amountY, int amountX)
        {
            this.InitializeComponent();
            this.ItemBoxes = new ItemBox[amountY][];
            for (int i = 0; i < this.ItemBoxes.Length; i++)
            {
                this.ItemBoxes[i] = new ItemBox[amountX];
            }


            for (int y = 0; y < amountY; y++)
            {
                for (int x = 0; x < amountX; x++)
                {
                    bool topBar = y == 0 ? true : false;
                    var itemBox = new ItemBox(topBar);
                    itemBox.Name = $"InvPanel-{x}-{y}";
                    int posX = (itemBox.Width * x) + (5 * x);
                    int posY = (itemBox.Height * y) + (5 * y);
                    itemBox.Location = new Point(posX, posY);

                    this.ItemBoxes[y][x] = itemBox;
                    this.Controls.Add(itemBox);
                }
            }
        }
    }
}
