using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;// We have to add the UnityEngine.UI namespace in order to work with Text variables

public class Ball : MonoBehaviour
{
    public Text scoretext;
    int score;
    public float speed = 8f;
    float hitFactor (Vector2 ballpos,Vector2 racketpos,float racketwidth)
    {
        return (ballpos.x - racketpos.x) / racketwidth;
    }
    void start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        //hit the racket?
        
        // calculate hit factor
            float x = hitFactor(transform.position,
                              col.transform.position,
                              col.collider.bounds.size.x);
            //calculate directon, set length to 1 
            Vector2 dir = new Vector2(x, 1).normalized;
            //set valocity with dir * speed;
            // Update is called once per frame
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        //this is our condition (if the ball collides with an object with the name block)
        if (col.gameObject.tag == "block")
        {
            //this line will just add 1 point to the score
            score++;
            //this line will convert the int score variable to a string variable
            scoretext.text = score.ToString();
        }
    }
    
}
