using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StrategyPatern;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;
public class Context : MonoBehaviour ,IStrategy
{
    public IStrategy currentStrategy;



    public void SetStrategy(IStrategy setStrategy)
    {
        currentStrategy = setStrategy;
    }
    public void Move(Rigidbody rgb, float velocity, Transform player, Transform target)
    {
        if (currentStrategy == null)
        {
            Debug.LogError("Route strategy not set");
            return;
        }
        currentStrategy.Move(rgb, velocity, player, target);

    }

}
