using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class ClassForScares : MonoBehaviour
{
    [Serializable]
    private class ObjectScares
    {
        public GameObject value1;
        public bool isActive;
    }

    [SerializeField] private ObjectScares[] objectScaresArray;



    public ChangeVignette vignetteChange;
    public float scareValue;

    public float timeBetweenScares;

    private void Awake()
    {
        StartCoroutine(timerForScare());
    }

    public void ActiveScares()
    {
        if (vignetteChange.sanityLevel >= 0.2f)
        {
            objectScaresArray[0].isActive = true;
        }
        else
        {
            objectScaresArray[0].isActive = false;
        }

        if (vignetteChange.sanityLevel >= 0.6f)
        {
            objectScaresArray[2].isActive = true;
        }
        else
        {
            objectScaresArray[2].isActive = false;
        }

        if (vignetteChange.sanityLevel >= 0.4f)
        {

            objectScaresArray[1].isActive = true;
        }
        else
        {

            objectScaresArray[1].isActive = false;
        }

    }

    // time a scare will occur (which gets more likely the more sanity depreciates)

    public void Selector()
    {
        objectScaresArray = objectScaresArray.OrderBy(variable => variable.isActive).ToArray();

        Debug.Log(objectScaresArray[0] + " " + objectScaresArray[1] + " " + objectScaresArray[2]);

    }

    IEnumerator timerForScare()
    {
        float timer = 0f;
        while (timer <= timeBetweenScares)
        {


            timer += Time.deltaTime;
            yield return null;




        }
        //ObjectReveal();
        Debug.Log("timer set to 0");
        timer = 0f;
        // goes to selector next

    }

    public void SanityChange()
    {
        // add a number to the sanity meter (this number needs to be consistant so it might as well be a stock number that gets called every scare)
        vignetteChange.AddSanityChange(scareValue / 10f);
        Debug.Log("sanityChangeActivated in SCP Spawner");
    }



    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.Space))
        {
            Selector();


        }

        ActiveScares();

    }

}
