﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Asteroids
{
    class PlayingState : GameObjectList
    {

        public PlayingState()
        {


            this.Add(new SpriteGameObject("spr_background"));
        }
    }
}
