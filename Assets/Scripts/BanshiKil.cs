using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanshiKil : MonoBehaviour
{
    public Camera mainCamera;
    public float maxDistance = 10f;
    public GameObject objectToDisable;

    public ClassForScares scareClass;

    void Update()
    {
        // Cast a ray from the camera forward
        RaycastHit hit;
        if (Physics.Raycast(mainCamera.transform.position, mainCamera.transform.forward, out hit, maxDistance))
        {
            // If the ray hits the object to be destroyed, disable it
            if (hit.collider.gameObject == objectToDisable)
            {
                Debug.Log("HIT");
                scareClass.FindAndTurnOff(gameObject);
            }
        }
    }
}