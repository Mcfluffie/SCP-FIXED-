using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oldman : MonoBehaviour
{
    public GameObject player;
    public float speed = 5f;
    private float timer = 0f;
    public GameObject childObject; // assign the child object in the inspector
    public GameObject parentObject; // assign the parent object in the inspector

    private void Update()
    {
        Vector3 direction = Vector3.Normalize(player.transform.position - transform.position);
        transform.Translate(direction * speed * Time.deltaTime);

        timer += Time.deltaTime;
        if (timer >= 10f)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == player)
        {
            Destroy(gameObject);
        }
    }

    private void OnEnable()
    {
        childObject.transform.SetParent(null);
    }

    private void OnDisable()
    {
        childObject.transform.SetParent(parentObject.transform);
    }
}
