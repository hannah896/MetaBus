using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CameraMove : MonoBehaviour
{
    public Transform target;

    float minX;
    float maxX;

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

    void FixedUpdate()
    {
        Vector3 currentPosition = transform.position;
        Vector2 targetPosition = target.position;

        float x = Mathf.Lerp(currentPosition.x, targetPosition.x, 0.02f);
        float y = Mathf.Lerp(currentPosition.y, targetPosition.y, 0.02f);

        transform.position = new(x, y, currentPosition.z);
    }
}
