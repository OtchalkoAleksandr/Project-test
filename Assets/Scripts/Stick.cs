using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Golf
{
    public class Stick : MonoBehaviour
    {
        public UnityEvent<Collider> onCollision;

#pragma warning disable IDE0051 // Удалите неиспользуемые закрытые члены
        private void OnCollisionEnter(Collision collision)
#pragma warning restore IDE0051 // Удалите неиспользуемые закрытые члены
        {
            onCollision.Invoke(collision.collider);
        }
    }
}