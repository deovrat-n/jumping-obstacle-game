﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    public float topBound = 34.0f;
    public float lowerBound = -11.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {  //destorying the objects which are not in the screen
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("GameOver!");
            Destroy(gameObject);
        }
    }
}
