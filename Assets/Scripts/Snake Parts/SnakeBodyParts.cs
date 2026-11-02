using UnityEngine;
using UnityEngine.AI;

public class SnakeBodyParts : MonoBehaviour
{
    [SerializeField] private Transform targetPositionTransform;

    private NavMeshAgent agent;

    public SnakeHead snakeH;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        snakeH = GameObject.FindWithTag("Snake").GetComponent<SnakeHead>();
    }

    // Update is called once per frame
    void Update()
    {
        if (snakeH.moving == true)
        {
            agent.destination = targetPositionTransform.position;
            agent.speed = 3.5f;
        }

        else
        {
            agent.speed = 0;
        }
    }
}
