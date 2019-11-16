using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabChecker : MonoBehaviour
{
    private OVRGrabber leftGrabbedObject, rightGrabbedObject;
    public GameObject leftController, rightController;
    public bool holding = false;

    // Start is called before the first frame update
    void Start()
    {
        leftGrabbedObject = leftController.GetComponent<OVRGrabber>();
        rightGrabbedObject = rightController.GetComponent<OVRGrabber>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void CheckGrab()
    {
        if (rightGrabbedObject.grabbedObject != null || leftGrabbedObject.grabbedObject != null)
        {
            holding = true;
        }

        else
        {
            holding = false;
        }
    }
}
