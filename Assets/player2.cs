using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour
{

    Vector2 direction;
    private float speed = 10;


    // Use this for initialization
    void Start()
    {
        direction = new Vector2(0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(direction * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-direction * speed * Time.deltaTime);
        }
    }
}
