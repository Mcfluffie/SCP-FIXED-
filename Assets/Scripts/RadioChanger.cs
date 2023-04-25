using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMOD;

public class RadioChanger : MonoBehaviour
{

    public FMODUnity.StudioEventEmitter myEventEmittertoplay;
    public FMODUnity.StudioEventEmitter HorrorRadio;


    [SerializeField]
    public FMODUnity.StudioEventEmitter myEventEmittertostop;
    public FMODUnity.StudioEventEmitter myEventEmittertostop2;
    public FMODUnity.StudioEventEmitter myEventEmittertostop3;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RadioTrigger"))
        {
            myEventEmittertoplay.Play();
            myEventEmittertostop.Stop();
            myEventEmittertostop2.Stop();
            myEventEmittertostop3.Stop();


        }
    

    }
}
     

