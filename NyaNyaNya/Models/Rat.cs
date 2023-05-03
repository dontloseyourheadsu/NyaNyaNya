using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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
        public int Recharge { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool Unlocked { get; set; }
        public List<int> Worlds { get; set; }
        public bool Alive { get; set; }
        public bool WasReleasedDuringWave { get; set; }
        public bool HasLanded { get; set; }
        public bool CanMove { get; set; }

        public Rat() { }
        public Rat(Rat rat)
        {
            Id = rat.Id;
            Name = rat.Name;
            Image = rat.Image;
            Life = rat.Life;
            Attack = rat.Attack;
            Speed = rat.Speed;
            Recharge = rat.Recharge;
            X = rat.X;
            Y = rat.Y;
            Width = rat.Width;
            Height = rat.Height;
            Unlocked = rat.Unlocked;
            Worlds = rat.Worlds;
            Alive = true;
            WasReleasedDuringWave = true;
            HasLanded = false;
            CanMove = true;
        }
    }
}
