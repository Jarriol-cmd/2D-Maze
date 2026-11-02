using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }


    void MovePlayer()
    {
        if(Keyboard.current.wKey.IsPressed())
        {
            rb.linearVelocityY += 0.1f;
        }

        if (Keyboard.current.sKey.IsPressed())
        {
            rb.linearVelocityY -= 0.1f;
        }

        if (Keyboard.current.dKey.IsPressed())
        {
            rb.linearVelocityX += 0.1f;
        }

        if (Keyboard.current.aKey.IsPressed())
        {
            rb.linearVelocityX -= 0.1f;
        }

    }
}
