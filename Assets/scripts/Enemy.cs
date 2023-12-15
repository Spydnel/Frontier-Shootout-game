using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    Vector2 velocity = Vector2.one;

    public float speed;

    [SerializeField]
    float zigzagTime = 1f;

    Rigidbody2D rigidBody;
    float timer;
    public float timer2;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        if (rigidBody == null)
        {
            Debug.Log("This object is missing a rigidbody!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*timer2 -= Time.deltaTime;

        if (timer2 < timer2 / 3)
        {
            rigidBody.velocity = Vector2.right * speed;
        }
        else if (timer2 < timer2 / 2)*/

        timer -= Time.deltaTime;
        ZigZagMovement();
    }

    void ZigZagMovement()
    {
        if(timer < 0)
        {
            velocity = new Vector2(-velocity.x, velocity.y);
            timer = zigzagTime;
        }


        rigidBody.velocity = velocity;
        
    }

    
}
