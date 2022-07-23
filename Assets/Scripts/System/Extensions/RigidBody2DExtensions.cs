using UnityEngine;

namespace DragonPackage
{
    public static class RigidBody2DExtensions
    {
        public static void SetVelocity(this Rigidbody2D rb2d, Vector2 velocity)
        {
            rb2d.velocity = velocity;
        }
    }
}

