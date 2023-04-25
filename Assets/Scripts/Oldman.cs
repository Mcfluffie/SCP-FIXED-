using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oldman : MonoBehaviour
{
    public GameObject player;
    public float speed = 5f;
    private float timer = 0f;
<<<<<<< HEAD
    public GameObject childObject; // assign the child object in the inspector
    public GameObject parentObject; // assign the parent object in the inspector
=======
    private Transform startingTransform;

    private void Start()
    {
        gameObject.transform.position = startingTransform.position;
    }
>>>>>>> visuals

    private void Update()
    {
        Vector3 direction = Vector3.Normalize(player.transform.position - transform.position);
        transform.Translate(direction * speed * Time.deltaTime);

        timer += Time.deltaTime;
        if (timer >= 10f)
        {
            gameObjectReset();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == player)
        {
            gameObjectReset();
        }
    }

<<<<<<< HEAD
    private void OnEnable()
    {
        childObject.transform.SetParent(null);
    }

    private void OnDisable()
    {
        childObject.transform.SetParent(parentObject.transform);
    }
}
=======
    private void gameObjectReset()
    {
        startingTransform.position = transform.position;
    }

}
>>>>>>> visuals
