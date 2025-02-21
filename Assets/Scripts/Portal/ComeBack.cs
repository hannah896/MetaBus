using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComeBack : BasePortal
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.Instance.isFall = false;
        SetfOnCollider();
    }
}
