using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Ball ball;
    public float speed;

	void Update ()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) && (transform.position.y < ball.borders.top - transform.localScale.y / 2))
        {
            transform.Translate(0, speed, 0);
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S) && (transform.position.y > ball.borders.bottom + transform.localScale.y / 2))
        {
            transform.Translate(0, -speed, 0);
        }
    }
}
