using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Asteroids
{
    class Rock : WrapableObject
    {
        private string assetname;

        public Rock(String assetname) : base(assetname)
        {
            this.assetname = assetname;
            this.Position = new Vector2(Asteroids.Random.Next(0, Asteroids.Screen.X-this.Sprite.Width), Asteroids.Random.Next(0, Asteroids.Screen.Y-this.Sprite.Height));
            this.Velocity = new Vector2(Asteroids.Random.Next(-100,100), Asteroids.Random.Next(-100,100));
        }
        public Rock(String assetname, Vector2 startPos, Vector2 startVel) : base(assetname)
        {
            this.assetname = assetname;
            this.position = startPos;
            this.velocity = startVel;

        }

        public string Assetname
        {
            get
            {
                return assetname;
            }

            set
            {
                assetname = value;
            }
        }

        public static String randomRockSize()
        {
            switch (Asteroids.Random.Next(1, 4))
            {
                case 1:
                    return "spr_rock1";
                case 2:
                    return "spr_rock2";
                case 3:
                    return "spr_rock3";
                default:
                    return "";
            }
        }
    }
}
