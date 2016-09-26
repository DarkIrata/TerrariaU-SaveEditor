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
    public partial class ItemBox : Panel
    {
        public ItemBox()
        {
            this.InitializeComponent();
            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = Color.FromArgb(0 ,178, 238);
            this.Size = new Size(45, 45);
        }
        
        public ItemBox(bool topBar)
            : this()
        {
            if (topBar)
            {
                this.BackColor = Color.FromArgb(0, 191, 255);
            }
        }
    }
}
