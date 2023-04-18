using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RadioInput : MonoBehaviour
{
    private RadioController controller; //radio controller reference
    private bool triggerEntered = false;
    public bool InvertradioDirection = false;

    /// <summary>
    /// Awake is called before Start.
    /// </summary>
    private void Awake()
    {
        TryGetComponent(out controller);    //find radio controller script attached to this object

        if (TryGetComponent(out controller))
        {
            Debug.Log("RadioController found");
        }
        else
        {
            Debug.Log("RadioController not found");
        }
    }

    /// <summary>
    /// Update is called once per frame.
    /// </summary>
    void Update()
    {

        if (controller != null && triggerEntered)
        {
            Debug.Log("NEXT");
            if (InvertradioDirection == false)
            {
                controller.CurrentStationIndex += 1;
            }
            else
            {
                controller.CurrentStationIndex -= 1;
            }

            triggerEntered = false;
        }
    }
    public void OnTriggerEnter(Collider other)
    {



        if (controller != null && other.CompareTag("RadioTrigger"))
        {
            Debug.Log("NEXT");
            if (InvertradioDirection == false)
            {
                controller.CurrentStationIndex += 1;
            }
            else
            {
                Debug.Log("perious");
                controller.CurrentStationIndex -= 1;
            }
        }



    }
}
