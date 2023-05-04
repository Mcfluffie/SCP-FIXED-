using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class radioButtons : MonoBehaviour
{
    public Material defaultMaterial;
    public Material highlightMaterial;

    private Renderer currentRenderer;

    private void Start()
    {
        currentRenderer = GetComponent<Renderer>();
        currentRenderer.material = defaultMaterial;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RadioTrigger"))
        {
            // Reset the color of the previously highlighted object
            if (currentRenderer != null)
            {
                currentRenderer.material = defaultMaterial;
            }

            // Highlight this object
            currentRenderer = GetComponent<Renderer>();
            currentRenderer.material = highlightMaterial;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("RadioTrigger"))
        {
            // Reset the color of the current object
            currentRenderer.material = defaultMaterial;

            // Reset the reference to the current renderer
            currentRenderer = null;
        }
    }
}
