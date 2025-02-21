using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComeBack : BasePortal
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SetfOnCollider();
    }
}
