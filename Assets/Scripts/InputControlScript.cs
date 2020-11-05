using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControlScript : MonoBehaviour
{
    //Add variables and references here
    public GameObject upCube;
    public GameObject downCube;
    public GameObject leftCube;
    public GameObject rightCube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Input for W Key and Up Arrow
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            upCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.UpArrow))
        {
            upCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }

        //Input for A Key and Left Arrow
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            leftCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            leftCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }

        //Input for S Key and Down Arrow
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            downCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.DownArrow))
        {
            downCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }

        //Input for D Key and Right Arrow
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            rightCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            rightCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }

    }
}
