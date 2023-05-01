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
        public GameObject objectInGame;
        public bool isAvailable;
        public float scareValue;
    }

    [SerializeField] private ObjectScares[] objectScaresArray;

    public int numberOfScaresThatArentNull;

    public ChangeVignette vignetteChange;
    
    public int numScaresOn;
    public float timeBetweenScares;
    public GameObject pickScare;
    public GameObject foundScare;


    public Fowardtest isSteering;


    // if i were to start over I would
    // make it so the script cycles through the array to find a scare that is available


    public void ActiveScares()
    {
        

        if (vignetteChange.sanityLevel >= 0.6f)
        {
            objectScaresArray[2].isAvailable = true;
        }
        else
        {
            objectScaresArray[2].isAvailable = false;
        }


    }

    // time a scare will occur (which gets more likely the more sanity depreciates)

    public void Selector()
    {
       if (numScaresOn <= objectScaresArray.Length - numberOfScaresThatArentNull)
        {
            // time between the scares happening
            timeBetweenScares = UnityEngine.Random.Range(8f, 20f / (numScaresOn + 1f));

            // which scare is selected
            int scareNumber = UnityEngine.Random.Range(0, objectScaresArray.Length - 1);

            if (objectScaresArray[scareNumber].objectInGame.activeSelf)
            {

                SortingIfAvailable(scareNumber);


            }
            else
            {

                pickScare = objectScaresArray[scareNumber].objectInGame;
                pickScare.SetActive(true);

            }
            SanityChange(scareNumber);
            StartCoroutine(timerForScare());

            if (numScaresOn < 2f)
            {
                numScaresOn++;

            }
        }

    }


    void SortingIfAvailable(int scareNum)
    {

        for (int i = 0; i < objectScaresArray.Length - 1f; i++)
        {

            if (!objectScaresArray[i].objectInGame.activeSelf && objectScaresArray[i].isAvailable)
            {

                scareNum = i;
                pickScare = objectScaresArray[scareNum].objectInGame;
                pickScare.SetActive(true);
            }
        }
    }

    
    // attach this to every script that is a scare
    public void FindAndTurnOff(GameObject thingToFind)
    {
        TurnOffItem(thingToFind);
    }


    void TurnOffItem(GameObject thingToFind)
    {
        for (int f = 0; f < objectScaresArray.Length - 1; f++)
        {

            if (objectScaresArray[f].objectInGame = thingToFind)
            {
                Debug.Log("successful removal of scare");
                foundScare = objectScaresArray[1].objectInGame;
                foundScare.SetActive(false);
                f = objectScaresArray.Length - 1;
                numScaresOn--;
            }

        }
    }

    IEnumerator timerForScare()
    {


        //yield return new WaitForSeconds(timeBetweenScares);
        float timer = 0f;
        while (timer <= timeBetweenScares)
        {

            timer += Time.deltaTime;
            yield return null;

        }

        if (numScaresOn > 2f)
        {
            StartCoroutine(timerForScare());
            Debug.Log("the coroutine restarts");
        }
        else
        {

            Selector();

        }

        Debug.Log("timer set to 0");
        

        // goes to selector next

    }

    // changes the sanity in the change vignette script

    public void SanityChange(int scareArrayPosition)
    {
        // add a number to the sanity meter (this number needs to be consistant so it might as well be a stock number that gets called every scare)

        if (vignetteChange.sanityLevel <= 0.6f)
        {
            vignetteChange.AddSanityChange(objectScaresArray[scareArrayPosition].scareValue / 10f);
        }
        else
        {
            vignetteChange.AddSanityChange((objectScaresArray[scareArrayPosition].scareValue / 10f));
        }

        
        Debug.Log("sanityChangeActivated in SCP Spawner");
    }

    // when a scare is removed
    

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (isSteering)
        {
            StartCoroutine(timerForScare());
        }

       

        ActiveScares();

    }

}
