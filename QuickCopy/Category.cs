using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickCopy
{
    public class Category
    {

        public Category(string name, bool expanded, Color color)
        {
            Name = name;
            Expanded = expanded;
            Color = color;
            Items = new Dictionary<Guid, Item>();
        }

        public string Name { get; set; }

        public bool Expanded { get; set; }

        public Color Color { get; set; }

        public Dictionary<Guid, Item> Items { get; set; }

    }
}
