using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handdissabled : MonoBehaviour
{
    public GameObject hand;
    public float delay ;
    private bool isDisabled = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RadioTriggerL"))
        {
            isDisabled = true;
            hand.SetActive(false);

           
        }
    }

   
}
