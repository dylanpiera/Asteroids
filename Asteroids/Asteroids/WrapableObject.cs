using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Asteroids
{
    class WrapableObject : RotatingSpriteGameObject
    {
        public WrapableObject(string assetname, int layer = 10, string id = "", int sheetIndex = 0) : base(assetname, layer, id, sheetIndex)
        {
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            this.WrapScreen();
        }

        protected void WrapScreen()
        {
            if (this.Position.X < 0) this.Position = new Vector2(Asteroids.Screen.X - this.Sprite.Width, this.Position.Y);
            if (this.Position.Y < 0) this.Position = new Vector2(this.Position.X, Asteroids.Screen.Y - this.Sprite.Height);
            if (this.Position.X > Asteroids.Screen.X - this.Sprite.Width) this.Position = new Vector2(0, this.Position.Y);
            if (this.Position.Y > Asteroids.Screen.Y - this.sprite.Height) this.Position = new Vector2(this.Position.X, 0);
        }
    }
}
