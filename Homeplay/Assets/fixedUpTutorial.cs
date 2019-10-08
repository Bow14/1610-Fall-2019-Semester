using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fixedUpTutorial : MonoBehaviour
{
    //This is a unity tutorial update and fixed update from the module page

    // Update is called once per frame
    private float fixedUpdateTimer;
    private float UpdateTimer;
    void FixedUpdate()
    {
        Debug.Log("I am fixing his mistakes : "+ Time.deltaTime);
    }
    
    
    void Update()
    {
        Debug.Log("Good Ol Update : "+ Time.deltaTime);
    }
}
