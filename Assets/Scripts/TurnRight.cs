using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnRight : MonoBehaviour
{
    public float forceAmount = 10f; // The amount of force to add to the object
    public ForceMode forceMode = ForceMode.Impulse; // The type of force to add
    public Rigidbody carRB;

    public void OnTriggerEnter(Collider other)
    {
        // If the trigger is hit by another object
        if (other.gameObject.tag == "Wheel")
        {
            Debug.Log("I COLLIDE");
            // Add a force to the object to make it move to the right
            other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * forceAmount, forceMode);
        }
    }
}
