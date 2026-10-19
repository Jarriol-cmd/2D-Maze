using Unity.Collections.LowLevel.Unsafe;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class StateMachine
{
    public State currentState, lastState;

    public IdleOrSlumbering idleState;
    public Chasing huntingState;
    public SnakeSlain dyingState;

    public StateMachine(SnakeHead enemP)
    {
        idleState = new IdleOrSlumbering(enemP, this);
        huntingState = new Chasing(enemP, this);
        dyingState = new SnakeSlain(enemP, this);
    }

    public void Init(State startingState)
    {
        currentState = startingState;
        lastState = null;
        startingState.Enter();
    }

    public void ChangeState(State newState)
    {
        currentState.Exit();

        lastState = currentState;
        currentState = newState;
        newState.Enter();
    }

    public void Update()
    {
        currentState.Update();
    }

    public void FixedUpdate()
    {
        currentState.FixedUpdate();
    }
}
