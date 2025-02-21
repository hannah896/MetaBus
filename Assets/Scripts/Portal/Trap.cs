using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : BasePortal
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SetfOffCollider();

            collision.GetComponent<Rigidbody2D>().gravityScale = 5;
            collision.GetComponent<Rigidbody2D>().AddTorque(10f);
            collision.GetComponent<Rigidbody2D>().freezeRotation = false;

            collision.GetComponentInChildren<SpriteRenderer>().sortingOrder = -20;

            GameManager.Instance.isFall = true;
        }
    }
}
