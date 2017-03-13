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

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);
        }

        public override void Reset()
        {
            base.Reset();
            this.Visible = false;
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            PlayingState ps = GameWorld as PlayingState;
            foreach (Rock rock in ps.Rocks.Objects)
            {
                if (this.CollidesWith(rock))
                {
                    switch (rock.Assetname)
                    {
                        case "spr_rock1":
                            ps.Rocks.Remove(rock);
                            this.Reset();
                            break;
                        case "spr_rock2":
                            this.Reset();
                            ps.Rocks.Add(new Rock("spr_rock1", rock.Position, rock.Velocity));
                            ps.Rocks.Remove(rock);
                            break;
                        case "spr_rock3":
                            this.Reset();
                            ps.Rocks.Add(new Rock("spr_rock2", rock.Position, rock.Velocity));
                            ps.Rocks.Remove(rock);
                            break;
                        default:
                            this.Reset();
                            break;
                    }
                    ps.Score.ScoreValue += 10;
                    break;
                }
            }
        }
    }
}
