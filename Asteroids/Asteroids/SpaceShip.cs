using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Asteroids
{
    class SpaceShip : WrapableObject
    {
        public SpaceShip(string assetname = "spr_spaceship", int layer = 10, string id = "", int sheetIndex = 0) : base(assetname, layer, id, sheetIndex)
        {
            this.Origin = this.Sprite.Center;  
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);
            if(inputHelper.IsKeyDown(Keys.Up))
            {
                this.Velocity += (this.AngularDirection * 5);
            }
            if(inputHelper.IsKeyDown(Keys.Down))
            {
                this.Velocity -= (this.AngularDirection * 5);
            }
            if(inputHelper.IsKeyDown(Keys.Left))
            {
                Degrees += 4;
            }
            if(inputHelper.IsKeyDown(Keys.Right))
            {
                Degrees -= 4;
            }
        }

        
    }
}
