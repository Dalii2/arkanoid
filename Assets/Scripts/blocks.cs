using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blocks : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collisioninfo)
    {
        //destroy the whole block 
        Destroy(gameObject);
    }
    void Update()
    {
        
    }
}
