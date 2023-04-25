using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopRainFromRotating : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.rotation = Quaternion.Euler(108.9f, 0f, 0f);
    }
}
