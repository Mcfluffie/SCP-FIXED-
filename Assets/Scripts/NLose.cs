using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NLose : MonoBehaviour
{
    public string levelName;

    public  void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("death"))
        {
            SceneManager.LoadScene(levelName);
        }
    }
}
