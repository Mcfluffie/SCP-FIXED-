using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostHand : MonoBehaviour
{
    public GameObject wheel1;
    public GameObject wheel2;
    public GameObject Ghosthand;
    public GameObject ghostwheel;
    // public Animator wheel;
    // public Steeringwheel steer;

    private bool ghostHandActive = false;

    void Start()
    {

    }

    private void OnEnable()
    {
        ghostHandActive = true;
       // wheel.Play("WheelControl");
       // steer.enabled = false; // disable the Steeringwheel script
        wheel1.SetActive(false);
        wheel2.SetActive(false);
        ghostwheel.SetActive(true);
    }

    private void OnDisable()
    {
        ghostHandActive = false;
       // wheel.Play("Wheeldle");
        wheel1.SetActive(true);
        wheel2.SetActive(true);
        ghostwheel.SetActive(false);
      //  steer.enabled = true; // enable the Steeringwheel script
    }

    public bool CanGrabWheel()
    {
       return !ghostHandActive;
    }
}
