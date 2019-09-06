using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour

{
    public float floathigh = 5.5f;

    public int intvaule = 25;
    public string stringvaule = "Bow";

    public int firepower;
    public UnityEvent Event;
    public Renderer _renderer;

    //I looked at many other peoples codes to see how it works but it is different from their codes
    public void OnTriggerEnter(Collider other)
    {
        print(other.name);
        if (other.name == "Bow")

            Event.Invoke();
        GetComponent<Renderer>().material.color = Color.yellow;
        Debug.Log("Bow Collided with Sphere" + other.gameObject.name);
    }


    // So i finally got the top part to work but to get it to be blue by press B will be a work in progress for tomorrow
    //So ive been editing and changing my code like crazy since 3:00 so im gonna finish it tomorrow but im proud of myself
//    public void Start()
//    {
//        if(Input.GetKeyDown(KeyCode.B))
//            GetComponent<Renderer> ().material.color = Color.blue;
//        print("Press B For Blue Collied For Yellow");
//        
//    }



//I went back to my tutorial Code #1 to figure out how to use the color thing in this code just a fyi
    void Update()
    {


        
    }
}
  

    

