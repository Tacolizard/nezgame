using System;
using Nez;
using Microsoft.Xna.Framework;

namespace nezgame
{
    public class Velocity : Component, IUpdatable
    {
        public float friction = 1f;
        public Vector2 velocity;

        public void impulse(Vector2 imp)
        { //apply an impulse to the entity
            velocity += imp;
        }

        void IUpdatable.update()
        {
            entity.transform.position += velocity * Time.deltaTime;
            velocity *= friction;
        }
    }
}
