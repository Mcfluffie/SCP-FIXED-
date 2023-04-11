//using System;
//using System.Collections;
//using System.Collections.Generic;
//using Unity.Mathematics;
//using UnityEngine;
//using System.Linq;

//public class SCPSpawner : MonoBehaviour
//{

//    //public ClassForScares[] objectScares = new ClassForScares[0];

//    public ClassForScares[] objectScares = new ClassForScares[0];

//    //public Collider triggerZone;
//    public Animator GhostHand;
//    public Animator Banshee;
//    public GameObject handObj;
//    public GameObject bansheeObj;
//    public GameObject thirdEntityObj;



//    public ChangeVignette vignetteChange;
//    public float scareValue;

//    public float timeBetweenScares;

//    private void Awake()
//    {

//        objectScares[0].value1 = thirdEntityObj.gameObject;
//        objectScares[1].value1 = handObj.gameObject;
//        objectScares[2].value1 = bansheeObj.gameObject;

//        StartCoroutine(timerForScare());
//    }

//    // the above changed to instead pass a piece of code to the script which it handles already to add to the sanity bar

//    // Random Spawn for each object with random.range
//    // Level of sanity affecting how many random spawns are active at any time
//    // sanity affect is in chunks


//    //public void OnTriggerEnter(Collider other)
//    //{
//    //    // If the trigger is hit by the player
//    //    if (other.CompareTag("Player"))
//    //    {
//    //        // Select a random GameObject from the array
//    //        int index = UnityEngine.Random.Range(0, objectsToActivate.Length);
//    //        GameObject objToActivate = objectsToActivate[index];

//    //        // Activate the selected GameObject
//    //        objToActivate.SetActive(true);
//    //        GhostHand.Play("GhosthandGrab");
//    //        Banshee.Play("Pose");


//    //        // Disable the trigger so it can't be activated again
//    //        triggerZone.enabled = false;
//    //    }
//    //}

//    // in here we need a random.range that controls the timing between events occuring (means we don't have to setup level design each time)
//    // Not sure how to go about differentiating each of them

//    // needs to have a timer which stops itself from activating so many times in less than a second
//    // maybe having a timer which stops the clock

//    // better yet, this method interacts by activating a random object from the available in the activate object method

//    public void RandomChanceEntities()
//    {




//        //// checks if bools are on to see how many objects it can use in object reveal

//        //if (handOn)
//        //{
//        //    numberActive = 3;
//        //}
//        //else if (thirdEntityOn)
//        //{
//        //    numberActive = 2;
//        //}




//        //// go through array and pick out an object between the number above and 1 (the first gameobject scare or the third)
//    }

//    public void ActiveScares()
//    {
//        if (vignetteChange.sanityLevel >= 0.2f)
//        {
//            objectScares[1].isActive = true;
//        }
//        else if (vignetteChange.sanityLevel >= 0.6f)
//        {

//            objectScares[2].isActive = true;
//        }
//        else if (vignetteChange.sanityLevel <= 0.6f)
//        {

//            objectScares[2].isActive = false;
//        }
//        else if (vignetteChange.sanityLevel <= 0.2f)
//        {
//            objectScares[1].isActive = false;
//        }
//    }

//    // time a scare will occur (which gets more likely the more sanity depreciates)

//    public void Selector()
//    {
//        objectScares.OrderBy(element => element.isActive);
//        Debug.Log(objectScares[0] + " " + objectScares[1] + " " + objectScares[2]);

//    }

//    IEnumerator timerForScare()
//    {
//        float timer = 0f;
//        while (timer <= timeBetweenScares)
//        {


//            timer += Time.deltaTime;
//            yield return null;




//        }
//        //ObjectReveal();
//        Debug.Log("timer set to 0");
//        timer = 0f;
//    }

//    public void SanityChange()
//    {
//        // add a number to the sanity meter (this number needs to be consistant so it might as well be a stock number that gets called every scare)
//        vignetteChange.AddSanityChange(scareValue / 10f);
//        Debug.Log("sanityChangeActivated in SCP Spawner");
//    }



//    // Start is called before the first frame update


//    // Update is called once per frame
//    void Update()
//    {


//        if (Input.GetKey(KeyCode.Space))
//        {
//            Selector();
//            Debug.Log("i pressed space");

//        }


//    }



//}
