using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPatern
{
    public class MovementFloor : IStrategy
    {
        public void Move(Rigidbody rgb, float velocity, Transform player, Transform target)
        {
            Debug.Log("MovementFloor");
            Vector3 direction =   target.position - player.position;
            Vector3 directionFlooor = new Vector3(direction.x, 0, direction.z);
            rgb.linearVelocity =(directionFlooor.normalized * velocity);
        }
    }
}
