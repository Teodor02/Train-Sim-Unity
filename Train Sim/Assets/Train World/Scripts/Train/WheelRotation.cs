using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotation : MonoBehaviour {

    public float Speed;

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(0,Speed,0);
        }
    }
}
