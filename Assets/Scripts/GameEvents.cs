using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{

    public static class GameEvents
    {
        public static System.Action onCollisionStone;
        public static System.Action onStickHit;

        public static void CollisionStenesInvoke(Collision collision)
        {
            onCollisionStone?.Invoke();
        }

        private static void OnStickHit()
        {
            onStickHit?.Invoke();
        }
    }
}