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

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("WINER");
            Win();
        }
    }

    public void Win()
    {
        WinScreen.SetActive(true);
        //emitter.play();
        Time.timeScale=0; 

    }
}
