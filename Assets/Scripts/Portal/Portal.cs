using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : BasePortal
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.GetComponentInChildren<SpriteRenderer>().sortingOrder = 0;
        collision.transform.position = new Vector3(0, 15, 0);
    }
}
