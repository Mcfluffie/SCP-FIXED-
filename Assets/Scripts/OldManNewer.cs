using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldManNewer : MonoBehaviour
{

    public GameObject player;
    public GameObject startPos;

    public float speed;

    public float timer;

    public ClassForScares scareClass;





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
                gameObject.transform.position = startPos.transform.position;
                scareClass.FindAndTurnOff(gameObject);
                timer = 2.7f;


            }
            
        }

        


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("ghost collide");
            scareClass.SanityChange(1);
        }
    }
}
