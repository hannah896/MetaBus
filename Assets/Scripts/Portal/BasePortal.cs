using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BasePortal : MonoBehaviour
{
    public GameObject Collider2dWall;
    public GameObject Collider2dObj;

    protected void SetfOffCollider()
    {
        Collider2dWall.SetActive(false);
        Collider2dObj.SetActive(false);
    }

    protected void SetfOnCollider()
    {
        Collider2dWall.SetActive(true);
        Collider2dObj.SetActive(true);
    }
}
