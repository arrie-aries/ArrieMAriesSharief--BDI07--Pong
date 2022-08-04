using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryController : MonoBehaviour
{
    public Collider2D ball;
    public bool rightWall;
    public ScoreManager manager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            if (rightWall)
            {
                manager.AddRightScore(1);
            }
            else
            {
                manager.AddLeftScore(1);
            }
        }
    }
}
