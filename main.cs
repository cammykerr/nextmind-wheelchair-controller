using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO.Ports;

public class main : MonoBehaviour
{
    SerialPort port;

    // Start is called before the first frame update
    void Start()
    {
        port = new SerialPort("COM6", 9600);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("space"))
        {
            port.Open();
            port.Write("1");
            port.Close();
        }
        else
        {
            port.Open();
            port.Write("2");
            port.Close();
        }
    }
}
