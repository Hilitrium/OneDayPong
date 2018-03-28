using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public int startForce = 2;
    public int startingDirection;
    Vector2 direction;
    private Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startingDirection = Random.Range(0, 1);
        Vector2 randomVector = new Vector2(1, 0);
        direction = randomVector;
    }
        void FixedUpdate()
    {
        if (startingDirection == 0)
        {
            rb.AddForce(direction);

        }
        else if (startingDirection == 1)
        {
            rb.AddForce(-direction);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        float timer = 0.2f;
        timer -= Time.deltaTime;
        if (timer <= 0) {
            if (startingDirection == 0)
            {
                startingDirection = 1;
            }
            else
            {
                startingDirection = 0;
            }

            if (startingDirection == 0)
            {
                rb.AddForce(direction, ForceMode2D.Impulse);

            }
            else if (startingDirection == 1)
            {
                rb.AddForce(-(direction), ForceMode2D.Impulse);

            }
            timer = 0.2f;
        }
    }
}
