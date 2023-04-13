using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window : MonoBehaviour
{
    public GameObject window;
    public GameObject ghosthand;
    public Animator anime;
    public float delay = 2f;
    public Animator wheel;

    public Animator ghosthandAnim;
    


    public void Start()
    {
        anime.Play("windowidel");
    }

    public void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RadioTrigger"))
        {
            anime.Play("window");
            ghosthandAnim.Play("ghost slip");
            Invoke("DeactivateGhostHand", delay);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("RadioTrigger"))
        {
            anime.Play("windowidel");
        }
    }

    private void DeactivateGhostHand()
    {
        ghosthand.SetActive(false);
    }
}