using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour {

    public GameObject player1;
    public GameObject player2;
    public GameObject ball;

    private Transform player1Transform;
    private Transform player2Transform;
    private Transform ballTransform;

	// Use this for initialization
	void Start () {
        player1Transform = player1.GetComponent<Transform>();
        player2Transform = player2.GetComponent<Transform>();
        ballTransform = ball.GetComponent<Transform>();
	}
	
	void restartLevel()
    {
        
    }
}
