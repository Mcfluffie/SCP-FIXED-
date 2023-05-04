using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMOD;

public class RadioChanger : MonoBehaviour
{
    public FMODUnity.StudioEventEmitter myEventEmittertoplay1;
    //public FMODUnity.StudioEventEmitter myEventEmittertoplay2;
    public FMODUnity.StudioEventEmitter HorrorRadio;

    [SerializeField]
    public FMODUnity.StudioEventEmitter myEventEmittertostop;
    public FMODUnity.StudioEventEmitter myEventEmittertostop2;
    public FMODUnity.StudioEventEmitter myEventEmittertostop3;
    public FMODUnity.StudioEventEmitter myEventEmittertostop4;
    public FMODUnity.StudioEventEmitter myEventEmittertostop5;
    public FMODUnity.StudioEventEmitter myEventEmittertostop6;

    // Start is called before the first frame update
    void Start()
    {
        // Start playing the initial station
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RadioTrigger"))
        {
            // Stop the current station
            myEventEmittertoplay1.Stop();
            myEventEmittertostop.Stop();
            myEventEmittertostop2.Stop();
            myEventEmittertostop3.Stop();
            myEventEmittertostop4.Stop();
            myEventEmittertostop5.Stop();
            myEventEmittertostop6.Stop();

            // Randomly choose whether to play the HorrorRadio or the initial station
            bool playHorrorRadio = Random.value < 0.2f;
            if (playHorrorRadio)
            {
                HorrorRadio.Play();
                myEventEmittertoplay1.Stop();
                myEventEmittertostop.Stop();
                myEventEmittertostop2.Stop();
                myEventEmittertostop3.Stop();
                myEventEmittertostop4.Stop();
                myEventEmittertostop5.Stop();
                myEventEmittertostop6.Stop();

            }
            else
            {
                myEventEmittertostop4.Stop();
                myEventEmittertostop5.Stop();
                myEventEmittertostop6.Stop();
                myEventEmittertoplay1.Stop();
                myEventEmittertostop.Stop();
                myEventEmittertostop2.Stop();
                myEventEmittertostop3.Stop();
                HorrorRadio.Stop();
                myEventEmittertoplay1.Play();
            }
        }
    }

}

