using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoyOutOfBounds : MonoBehaviour
{

    private float topBound = 30;
    private float lowerBound = -10;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("YOOOO?");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject); 
        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject); 
        }
    }
}
