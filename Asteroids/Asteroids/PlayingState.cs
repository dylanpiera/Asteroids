using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Centipede;

namespace Asteroids
{
    class PlayingState : GameObjectList
    {
        SpaceShip spaceShip;
        GameObjectList bullets, rocks;
        Centipede.Score score;

        public GameObjectList Rocks
        {
            get
            {
                return rocks;
            }

            set
            {
                rocks = value;
            }
        }
        public GameObjectList Bullets
        {
            get
            {
                return bullets;
            }

            set
            {
                bullets = value;
            }
        }

        internal Score Score
        {
            get
            {
                return score;
            }

            set
            {
                score = value;
            }
        }

        public PlayingState()
        {
            spaceShip = new SpaceShip();
            bullets = new GameObjectList();
            rocks = new GameObjectList();
            score = new Score();

            for (int i = 0; i < 19; i++)
            {
                this.rocks.Add(new Rock(Rock.randomRockSize()));
            }

            this.Add(new SpriteGameObject("spr_background"));
            this.Add(bullets);
            this.Add(rocks);
            this.Add(spaceShip);
            this.Add(score);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            foreach (Bullet bullet in Bullets.Objects)
            {
                if(!bullet.Visible)
                {
                    bullets.Remove(bullet);
                    break;
                }
            }

            foreach (Rock rock in rocks.Objects)
            {
                if (spaceShip.CollidesWith(rock)) Asteroids.GameStateManager.SwitchTo(Asteroids.gameoverState);
            }
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
