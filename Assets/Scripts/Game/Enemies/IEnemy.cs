﻿using Game.Gun;

namespace Game
{
    public interface IEnemy
    {
        void OnHit(IGun gun);
    }
}