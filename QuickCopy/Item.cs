using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickCopy
{
    public class Item
    {

        public Item(string name, string content, Color color)
        {
            Name = name;
            Content = content;
            Color = color;
        }

        public string Name { get; set; }

        public string Content { get; set; }

        public Color Color { get; set; }

    }
}
