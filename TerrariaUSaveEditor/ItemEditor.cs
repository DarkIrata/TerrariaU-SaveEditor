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
    public partial class ItemEditor : UserControl
    {
        public ItemEditor()
        {
            this.InitializeComponent();

        }

        public void LoadInventoryItem(InventoryData data)
        {
            this.NudItemId.Value = data.Item.Id;
            this.NudAmount.Value = data.Amount;

        }
    }
}
