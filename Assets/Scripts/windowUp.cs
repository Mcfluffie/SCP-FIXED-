using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windowUp : MonoBehaviour
{
    public GameObject window;
    
    public Animator anime;
   
    public void Start()
    {
        
    }

    public void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RadioTrigger"))
        {
            anime.Play("Window up");
           
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("RadioTrigger"))
        {
            anime.Play("windowidle");
        }
    }

  
}
