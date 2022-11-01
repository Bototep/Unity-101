using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //print("I need healing");
        //+print(transform.position);

        if (Input.GetKey(KeyCode.W))
        {
            //print("W");
            transform.position = new Vector3(0, transform.position.y + 0.001f, 0);         
        }
        if (Input.GetKey(KeyCode.S))
        {
            //print("W");
            transform.position = new Vector3(0, transform.position.y - 0.001f, 0); 
            
        }
        if (Input.GetKey(KeyCode.A))
        {
            //print("W");
            transform.position = new Vector3(transform.position.x - 0.001f, 0, 0);

        }
        if (Input.GetKey(KeyCode.D))
        {
            //print("W");
            transform.position = new Vector3(transform.position.x + 0.001f, 0, 0);

        }
    }

}
