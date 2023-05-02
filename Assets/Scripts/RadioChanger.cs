using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMOD;

public class RadioChanger : MonoBehaviour
{
    public FMODUnity.StudioEventEmitter myEventEmittertoplay1;
    public FMODUnity.StudioEventEmitter myEventEmittertoplay2;
    public FMODUnity.StudioEventEmitter HorrorRadio;

    [SerializeField]
    public FMODUnity.StudioEventEmitter myEventEmittertostop;
    public FMODUnity.StudioEventEmitter myEventEmittertostop2;
    public FMODUnity.StudioEventEmitter myEventEmittertostop3;

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

            // Randomly choose whether to play the HorrorRadio or the initial station
            bool playHorrorRadio = Random.value < 0.5f;
            if (playHorrorRadio)
            {
                myEventEmittertoplay2.Play();
                HorrorRadio.Play();
            }
            else
            {
                myEventEmittertoplay1.Play();
            }
        }
    }

}

