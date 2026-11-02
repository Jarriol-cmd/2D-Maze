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
        targetPositionTransform = GameObject.FindWithTag("Player").transform;

        agent.speed = 3.5f;

        enemP.moving = true;
    }

    public override void Exit()
    {

        enemP.moving = false;

    }

    public override void Update()
    {
        agent.SetDestination(targetPositionTransform.position);
    }
}
