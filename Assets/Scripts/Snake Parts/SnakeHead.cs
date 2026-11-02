using UnityEngine;
using UnityEngine.AI;

public class SnakeHead : MonoBehaviour
{
    StateMachine sm;

    public bool moving;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sm = new StateMachine(this);
        sm.Init(sm.idleState);

    }

    // Update is called once per frame
    void Update()
    {
        sm.Update();


        
    }

    private void FixedUpdate()
    {
        
        sm.FixedUpdate();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        sm.currentState.OnCollisionEnter2D(collision);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        sm.currentState.OnTriggerEnter2D(collision);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        sm.currentState.OnTriggerStay2D(collision);
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        sm.currentState.OnTriggerExit2D(collision);
    }
}
