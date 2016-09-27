using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaUSaveEditor.GameData
{
    public class ItemData
    {
        public int Id { get; set; }

        // public string Image { get; set; }

        public string Name { get; set; }

        public ItemData()
        {
            this.Id = 0;
            this.Name = "Empty";
        }

        public ItemData(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
