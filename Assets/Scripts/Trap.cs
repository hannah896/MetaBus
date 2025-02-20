using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public GameObject Collider2d;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Collider2d.SetActive(false);

            collision.GetComponent<Rigidbody2D>().gravityScale = 5;
            collision.GetComponent<Rigidbody2D>().AddTorque(10f);
            collision.GetComponent<Rigidbody2D>().freezeRotation = false;

            collision.GetComponentInChildren<SpriteRenderer>().sortingOrder = -20;
        }
    }
}
