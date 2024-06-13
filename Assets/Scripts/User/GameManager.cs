using StrategyPatern;
using UnityEngine;
public enum TypeMove { moveFloor, moveSlow, moveAir,none};

public class GameManager : MonoBehaviour
{
    [SerializeField] Context context;
    [SerializeField] GameObject player;
    [SerializeField] Rigidbody playerrgb;
    [SerializeField] Transform Target;
    [SerializeField] Animator characterController;
    [SerializeField] float  velocity;
    public TypeMove currentType;
    private void Start()
    {
        currentType = TypeMove.none;    
        context.SetStrategy(new MovementFloor());
        context.currentStrategy.Move(playerrgb, 0, player.transform, Target);
        characterController = player.GetComponent<Animator>();

    }
    public void Walk()
    {
        characterController.SetFloat("Blend", 0.6f, 0, Time.deltaTime);
        currentType = TypeMove.moveFloor;
        context.SetStrategy(new MovementFloor());
    }   
    public void Fly()
    {
        characterController.SetFloat("Blend", 0.6f, 0, Time.deltaTime);
        currentType = TypeMove.moveAir;
        context.SetStrategy(new MovementAir());
    }
    public void Slow()
    {
        characterController.SetFloat("Blend", 0.25f, 0, Time.deltaTime);
        currentType = TypeMove.moveSlow;
        context.SetStrategy(new MovementSlow());
    }
  
    public void None()
    {
        player.transform.position = Vector3.zero;
        context.currentStrategy.Move(playerrgb, 0, player.transform, Target);
    }


    private void Update()
    {

        context.currentStrategy.Move(playerrgb, velocity, player.transform, Target);
    }



}
