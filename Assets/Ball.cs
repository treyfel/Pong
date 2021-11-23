using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public float speed = 2;
    private Vector2 direction;

    private float ballRadius;
    private static Vector2 bottomLeft;
    private static Vector2 topRight;

    private Score _score;

	// Use this for initialization
    void Start () {
        direction = new Vector2(1, 1).normalized;
        _score = GameObject.FindWithTag("Score").GetComponent<Score>();
        ballRadius = transform.localScale.x / 2;

        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(direction * speed * Time.deltaTime);

        if(transform.position.y > topRight.y - ballRadius && direction.y > 0)
        {
            direction.y = -direction.y;
        }
        if (transform.position.y < bottomLeft.y + ballRadius && direction.y < 0)
        {
            direction.y = -direction.y;
        }
        if (transform.position.x > topRight.x - ballRadius && direction.x > 0)
        {
            ResetPosition();
            _score.increase_left();
        }
        if (transform.position.x < bottomLeft.x + ballRadius && direction.x < 0)
        {
            ResetPosition();
            _score.increase_right();
        }
    }

    private void ResetPosition()
    {
        direction = new Vector2(1, 1).normalized;
        transform.position = new Vector3(0, 0, 0);
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        direction.x = - direction.x;
    }

}
