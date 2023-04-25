using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oldman : MonoBehaviour
{
    public GameObject player;
    public float speed = 5f;
    private float timer = 0f;
    private Transform startingTransform;

    private void Start()
    {
        gameObject.transform.position = startingTransform.position;
    }

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

    private void gameObjectReset()
    {
        startingTransform.position = transform.position;
    }

}
