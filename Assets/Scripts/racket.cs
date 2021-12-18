using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class racket: MonoBehaviour
{
    // Mouvement Speed
    public float speed = 15;
    private void FixedUpdate()
    {
        // get horizontal input
    
        float h = Input.GetAxisRaw("Horizontal");

        //set velocity (mouvement directon*speed)
        GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed;
    }
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
