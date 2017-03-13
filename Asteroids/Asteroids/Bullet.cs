using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Asteroids
{
    class Bullet : SpriteGameObject
    {
        public Bullet(Vector2 startPos, Vector2 startSpe, string assetname = "spr_bullet", int layer = 10, string id = "", int sheetIndex = 0) : base(assetname, layer, id, sheetIndex)
        {
            this.Position = startPos;
            this.Velocity = startSpe;
        }
    }
}
