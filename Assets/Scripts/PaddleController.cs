using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public KeyCode moveUp;
    public KeyCode moveDown;
    private float boundY = 3.75f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

      void Update()
    {   
        MoveObject(GetInput());

        //boundary walls dan paddles
        var pos = transform.position;
        if (pos.y > boundY)
        {
            pos.y = boundY;
        }
        else if (pos.y < -boundY)
        {
            pos.y = -boundY;
        }
        transform.position = pos;
    }

    private Vector2 GetInput()
    {
                
        if (Input.GetKey(moveUp))
        {
            return Vector2.up * speed;
        }
        else if (Input.GetKey(moveDown))
        {
            return Vector2.down * speed;
        }

        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
        rb.velocity = movement;
    }
}
