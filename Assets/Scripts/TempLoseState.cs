using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempLoseState : MonoBehaviour
{
    public LoseState loseState;
    void Update()
    {
        if (loseState.LoseScreen.activeSelf == true)
        {
            Application.Quit();
        }
    }
}
