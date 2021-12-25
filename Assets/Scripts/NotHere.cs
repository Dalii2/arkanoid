using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotHere : MonoBehaviour
{
    // Start is called before the first frame update



    void OnMouseDown()
    {

        gameObject.SetActive(false);

        Debug.Log("disappeared");
        
    }
}


