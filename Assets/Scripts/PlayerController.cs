using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    private Rigidbody2D rb;
    public int Player = 1;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
	
    void Update()
    {
        
        if (Player == 1)
        {
            float moveVertical = Input.GetAxis("Vertical");
            Vector2 movement = new Vector2(0, moveVertical);
            rb.AddForce(movement * speed);
        }
        if (Player == 2)
        {
            float moveVertical = Input.GetAxis("Vertical2");
            Vector2 movement = new Vector2(0, moveVertical);
            rb.AddForce(movement * speed);
        }
    }
}
