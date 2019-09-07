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

    //I looked at many other peoples codes to see how it works but it is different from their codes and jetbrains helped experiment with it
    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
        
        print("A Or B For Color Change Or slam into sphere");
    }

    public void OnTriggerEnter(Collider other)
    {
        print(other.name);
        if (other.name == "Bow")

            Event.Invoke();
        GetComponent<Renderer>().material.color = Color.yellow;
        Debug.Log("You Have Become Yellow");
    }


    
    public void Start()
    {
        
   }



//I went back to my tutorial Code #1 to figure out how to use the color thing in this code just a fyi
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
            _renderer.material.color = Color.blue;
        if (Input.GetKeyDown(KeyCode.A))
            _renderer.material.color = Color.cyan;


    }
}
  

    

