using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPatern
{
    public interface IStrategy
    {
        public void Move(Rigidbody rgb, float velocity, Transform player, Transform target) {
            Debug.Log("Padre");
        }
        
    }
}

