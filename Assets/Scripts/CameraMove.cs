using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CameraMove : MonoBehaviour
{
    public Transform target;

    private Vector2 pos;

    private GameManager gameManager;

    private void Awake()
    {
        pos = Vector2.zero;
    }

    void Start()
    {
        gameManager = GameManager.Instance;
    }

    private void LateUpdate()
    {
        transform.position = target.position;

        if (!gameManager.isFall)
        {
            float x = Mathf.Clamp(transform.position.x, -2f, 2f);
            float y = Mathf.Clamp(transform.position.y, 0f, 1f);
            transform.position = new Vector2(x, y);
        }
    }
}
