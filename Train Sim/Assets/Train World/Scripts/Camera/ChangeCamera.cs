using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public Camera TopDown, FirstPerson, ThirdPerson;
    public KeyCode TopDownKey;
    public KeyCode FirstPersonKey;
    public KeyCode  ThirdPersonKey;
    public bool TopDownCam = false;
    public bool FirstPersonCam = false;
    public bool ThirdPersonCam = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(TopDownKey))
        {
            TopDownCam = true;
            FirstPersonCam = false;
            ThirdPersonCam = false;
            TopDown.gameObject.SetActive(TopDownCam);
            FirstPerson.gameObject.SetActive(FirstPersonCam);
            ThirdPerson.gameObject.SetActive(ThirdPersonCam);
        }
        if (Input.GetKey(FirstPersonKey))
        {
            TopDownCam = false;
            FirstPersonCam = true;
            ThirdPersonCam = false;
            TopDown.gameObject.SetActive(TopDownCam);
            FirstPerson.gameObject.SetActive(FirstPersonCam);
            ThirdPerson.gameObject.SetActive(ThirdPersonCam);
        }
        if (Input.GetKey(ThirdPersonKey))
        {
            TopDownCam = false;
            FirstPersonCam = false;
            ThirdPersonCam = true;
            TopDown.gameObject.SetActive(TopDownCam);
            FirstPerson.gameObject.SetActive(FirstPersonCam);
            ThirdPerson.gameObject.SetActive(ThirdPersonCam);
        }
    }
}
