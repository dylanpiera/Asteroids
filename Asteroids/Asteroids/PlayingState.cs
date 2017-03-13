using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Asteroids
{
    class PlayingState : GameObjectList
    {
        SpaceShip spaceShip;
        GameObjectList bullets;

        public PlayingState()
        {
            spaceShip = new SpaceShip();
            bullets = new GameObjectList();

            this.Add(new SpriteGameObject("spr_background"));
            this.Add(bullets);
            this.Add(spaceShip);
            
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);

            if(inputHelper.KeyPressed(Keys.Space))
            {
                this.bullets.Add(new Bullet(this.spaceShip.Position,this.spaceShip.AngularDirection * 300));
            }
        }
    }
}
