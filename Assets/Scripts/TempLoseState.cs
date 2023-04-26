using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempLoseState : MonoBehaviour
{

    public LoseState loseState;
    void Update()
    {

        //Ray ray = new Ray(transform.position, Vector3.down);

        //Debug.DrawLine(ray.origin, ray.origin + Vector3.down * 1.1f);

        //if ()


        if (loseState.LoseScreen.activeSelf == true)
        {
            Application.Quit();
        }
    }
}
