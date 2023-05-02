using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldManNewer : MonoBehaviour
{

    public GameObject player;

    public float speed;

    public float timer;

    

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position != gameObject.transform.position)
        {
            Vector3 direction = Vector3.Normalize(player.transform.position - transform.position);
            transform.Translate(direction * speed * Time.deltaTime);

            timer += Time.deltaTime;
            if (timer >= 10f)
            {
                timer = 0f;
                gameObject.SetActive(false);

            }
        }

        


    }
}