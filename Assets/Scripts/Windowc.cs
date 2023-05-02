using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Windowc : MonoBehaviour
{
    public GameObject window;
    public GameObject ghosthand;
    public Animator anime;
    public float delay = 2f;
   

    public Animator ghosthandAnim;
    


    public void Start()
    {
        anime.Play("windowidle");
    }

    public void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RadioTrigger"))
        {
            anime.Play("Window");
            ghosthandAnim.Play("Ghost_Hand_Slip");
            Invoke("DeactivateGhostHand", delay);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("RadioTrigger"))
        {
            anime.Play("windowidle");
        }
    }

    private void DeactivateGhostHand()
    {
        ghosthand.SetActive(false);
    }
}