using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinState : MonoBehaviour
{
    public GameObject WinScreen;

    


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Win")
        {
            Win();
        }
    }

    void Win()
    {
        WinScreen.SetActive(true);
        //emitter.play();
        Time.timeScale=0; 

    }
}
