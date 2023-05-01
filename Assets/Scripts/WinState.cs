using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WinState : MonoBehaviour
{
    public GameObject WinScreen;

    private void Start()
    {
        WinScreen.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (CompareTag("Player"))
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
