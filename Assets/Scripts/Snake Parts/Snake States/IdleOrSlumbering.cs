using System;
using UnityEngine;

public class IdleOrSlumbering : State
{

    float distance;

    public IdleOrSlumbering(SnakeHead enemP, StateMachine sm) : base(enemP, sm)
    {
    }

    public override void Enter()
    {

        player = GameObject.FindWithTag("Player");
        snake = GameObject.FindWithTag("Snake");

    }

    public override void Exit()
    {
        

        
    }

    public override void Update()
    {
        distance = Vector3.Distance(player.transform.position, snake.transform.position);

        if (distance < 6)
        {
            sm.ChangeState(sm.huntingState);
        }

        Debug.Log(distance);
    }

}
