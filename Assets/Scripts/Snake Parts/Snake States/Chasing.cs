using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class Chasing : State
{

    

    public Chasing(SnakeHead enemP, StateMachine sm) : base(enemP, sm)
    {
    }

    public override void Enter()
    {

        agent = GameObject.FindWithTag("Snake").GetComponent<NavMeshAgent>();
        targetPositionTransform = player.transform;
    }

    public override void Exit()
    {



    }

    public override void Update()
    {
        agent.destination = targetPositionTransform.position;
    }
}
