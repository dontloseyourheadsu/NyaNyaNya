using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyaNyaNya.Models
{
    public class Cat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Life { get; set; }
        public int Attack { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public bool Unlocked { get; set; }
    }
}
