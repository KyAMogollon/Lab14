using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace StrategyPatern
{
    public class MovementSlow : IStrategy
    {

        public void Move(Rigidbody rgb, float velocity, Transform player, Transform target)
        {
            Debug.Log("MovementSlow");
            Vector3 direction = target.position- player.position;
            Vector3 directionFlooor = new Vector3(direction.x, 0, direction.z);
            rgb.linearVelocity = (directionFlooor.normalized *(velocity / 2)) ;
        }
    }
}

