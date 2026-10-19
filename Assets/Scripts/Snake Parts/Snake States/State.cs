using UnityEngine;
using UnityEngine.AI;

public class State
{
    protected SnakeHead enemP;
    protected StateMachine sm;
    protected GameObject player;
    protected GameObject snake;

    protected NavMeshAgent agent;
    protected Transform targetPositionTransform;

    public State(SnakeHead enemP, StateMachine sm)
    {
        this.enemP = enemP;
        this.sm = sm;
    }

    public virtual void Enter() { }
    public virtual void Update() { }
    public virtual void FixedUpdate() { }
    public virtual void Exit() { }
    public virtual void OnCollisionEnter2D(Collision2D collision) { }
    public virtual void OnTriggerEnter2D(Collider2D collision) { }
    public virtual void OnTriggerStay2D(Collider2D collision) { }
    public virtual void OnTriggerExit2D(Collider2D collision) { }
}
