using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class VibrationOnTrigger : MonoBehaviour
{
    public XRController controller;
    public float vibrationDuration = 0.2f;
    public float vibrationStrength = 1.0f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            controller = other.GetComponent<XRController>();
            if (controller != null)
            {
                controller.SendHapticImpulse(vibrationStrength, vibrationDuration);
            }
        }
    }
}
