using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheel : MonoBehaviour
{

    public GameObject wheela;
    public Animator aime;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RadioTriggerL"))
        {
            aime.Play("WheeLeft");
        } else if (other.CompareTag("RadioTrigger"))
        {
            aime.Play("wheel right");
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("RadioTriggerL"))
        {
            aime.Play("WheelIdel");
        } else if (other.CompareTag("RadioTrigger"))
        {
            aime.Play("WheelIdel");
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
