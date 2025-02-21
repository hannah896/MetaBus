using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : BasePortal
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.transform.position = new Vector3(0, 50, 0);
    }
}
