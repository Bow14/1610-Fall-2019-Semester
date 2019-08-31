using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    private Renderer _renderer;

    // Start is called before the first frame update
    public void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            _renderer.material.color = Color.green;
        }


        if (Input.GetKeyDown(KeyCode.W))
        {
            _renderer.material.color = Color.magenta;
        }


        if (Input.GetKeyDown(KeyCode.B))
        {
            _renderer.material.color = Color.blue;
        }

  


    }
}
