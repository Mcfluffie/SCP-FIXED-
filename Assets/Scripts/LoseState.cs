using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class LoseState : MonoBehaviour
{
   public float raycastDistance = 1.0f; // The distance the raycast will travel
    public string raycastTag = "death"; // The tag to filter the raycast

    public FMODUnity.StudioEventEmitter emitter;

    public GameObject LoseScreen;

    void Update()
    {
        // Shoot a raycast down from the player
        RaycastHit hitInfo;
        Debug.DrawLine(transform.position, Vector3.down);
        if (Physics.Raycast(transform.position, Vector3.down, out hitInfo, raycastDistance))
        {
            // The raycast hit something
            if (hitInfo.collider.CompareTag(raycastTag))
            {
                Lose();
                Debug.Log("Hit object: " + hitInfo.collider.gameObject.name);
            }
            else
            {
                // The raycast hit something that doesn't have the specified tag
                Debug.Log("Hit object does not have the specified tag.");
            }
        }
        else
        {
            // The raycast did not hit anything
            Debug.Log("Did not hit anything.");
        }
    }

    void Lose()
    {
        LoseScreen.SetActive(true);
        //emitter.play();
        Time.timeScale=0; 

    }

}
