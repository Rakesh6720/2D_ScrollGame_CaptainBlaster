using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float speed = 10f;

    GameManager gameManager; // Note this is private this time

	// Use this for initialization
	void Start () {
        //Because the bullet doesn't exist until the game is running
        //we must find the Game Manager a different way
        gameManager = GameObject.FindObjectOfType<GameManager>();

        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = new Vector2(0f, speed);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject); // Destroy the meteor
        gameManager.AddScore(); // Increment the score
        Destroy(gameObject); // Destroy the bullet
    }
}
