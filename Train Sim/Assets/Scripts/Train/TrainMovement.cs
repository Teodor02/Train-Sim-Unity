using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainMovement : MonoBehaviour
{
    public float Speed;
    public Collider FL;
    public Collider FR;
    public Collider RL;
    public Collider RR;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * Speed;
        }
    }
}
