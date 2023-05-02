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
        public int Recharge { get; set; }
        public int Price { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool Unlocked { get; set; }
        public bool[] Projectiles { get; set; }
        public bool[] ProjectilesFirstActive { get; set; }
        public int[] ProjectilesX { get; set; }
        public int[] ProjectilesY { get; set; }
        public int ProjectileIndex { get; set; }
        public bool ProjectileFirstLoop { get; set; }

        public Cat() { }
        public Cat(Cat cat)
        {
            Id = cat.Id;
            Name = cat.Name;
            Image = cat.Image;
            Life = cat.Life;
            Attack = cat.Attack;
            Recharge = cat.Recharge;
            Price = cat.Price;
            X = cat.X;
            Y = cat.Y;
            Width = cat.Width;
            Height = cat.Height;
            Unlocked = cat.Unlocked;
            Projectiles = new bool[5];
            ProjectilesFirstActive= new bool[5];
            ProjectilesX = new int[5];
            ProjectilesY = new int[5];

            for(int i = 0; i < 5; i++)
            {
                Projectiles[i] = false;
                ProjectilesFirstActive[i] = true;
                ProjectilesX[i] = 0;
                ProjectilesY[i] = 0;
            }
            ProjectileIndex = 0;
            ProjectileFirstLoop = true;
        }
    }
}
