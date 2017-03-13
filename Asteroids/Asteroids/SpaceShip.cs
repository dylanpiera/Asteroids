using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Asteroids
{
    class SpaceShip : RotatingSpriteGameObject
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

            this.WrapScreen();
        }

        private void WrapScreen()
        {
            if (this.Position.X < 0) this.Position = new Vector2(Asteroids.Screen.X - this.Sprite.Width, this.Position.Y);
            if (this.Position.Y < 0) this.Position = new Vector2(this.Position.X, Asteroids.Screen.Y - this.Sprite.Height);
            if (this.Position.X > Asteroids.Screen.X - this.Sprite.Width) this.Position = new Vector2(0, this.Position.Y);
            if (this.Position.Y > Asteroids.Screen.Y - this.sprite.Height) this.Position = new Vector2(this.Position.X, 0);
        }
    }
}
