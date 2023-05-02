using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyaNyaNya.Models
{
    public class Rat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Life { get; set; }
        public int Attack { get; set; }
        public int Speed { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool Unlocked { get; set; }
        public List<int> Worlds { get; set; }
    }
}
