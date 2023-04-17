using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oldman : MonoBehaviour
{
    public GameObject player;
    public float speed = 5f;
    private float timer = 0f;

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
}
