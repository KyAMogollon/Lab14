using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace StrategyPatern
{
    public class MovementAir : IStrategy
    {
        public void Move(Rigidbody rgb, float velocity, Transform player, Transform target)
        {
            Debug.Log("MovementAir");
            Vector3 direction = target.position - player.position;
            rgb.linearVelocity = (direction.normalized * velocity);
        }
    }
}

