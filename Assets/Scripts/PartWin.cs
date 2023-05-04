using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartWin : MonoBehaviour
{
    public ParticleSystem part;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Object")) 
        {
            part.Play();
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
