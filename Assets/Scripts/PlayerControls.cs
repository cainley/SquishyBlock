using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public Rigidbody2D rb;
    float speed = 0.022f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Movement
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-speed, 0, 0);
            Debug.Log("A key was pressed.");
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed, 0, 0);
            Debug.Log("D key was pressed.");
        }


        //Mechanic (Squishing the Block)
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.localScale = new Vector3(0.25f, 0.75f, 0.75f);
            Debug.Log("W key was pressed.");
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
            Debug.Log("W key was released.");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.localScale = new Vector3(0.75f, 0.25f, 0.75f);
            Debug.Log("S key was pressed.");
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
            Debug.Log("S key was released.");
        }

    }
}
