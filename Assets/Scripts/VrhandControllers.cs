using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class VrhandControllers : MonoBehaviour
{

    [SerializeField] private InputActionProperty triggerAction;
    [SerializeField] private InputActionProperty gripAction;

    private Animator anime;


    // Start is called before the first frame update
    private void Start()
    {
        anime = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        float triggervalue = triggerAction.action.ReadValue<float>();
        float gripvalue = gripAction.action.ReadValue<float>();

        anime.SetFloat("Trigger", triggervalue);
        anime.SetFloat("Grip", gripvalue);
    }
}
