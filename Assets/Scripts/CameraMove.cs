using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CameraMove : MonoBehaviour
{
    public Transform target;
    float offsetX;
    float offsetY;
    float camHalfWidth;
    float camHalfHeight;

    public Tilemap tileMap;

    Bounds bounds;

    void Start()
    {
        if (target == null || tileMap == null) return;

        BoundsInt cellBounds = tileMap.cellBounds;
        camHalfWidth = Camera.main.orthographicSize * Camera.main.aspect;
        camHalfHeight = Camera.main.orthographicSize;

        offsetX = transform.position.x - target.position.x; ; //�÷��̾�� ī�޶� ������ �Ÿ�
        offsetY = transform.position.y - target.position.y;

        GetTilemapBounds();
    }

    void Update()
    {
        if (target == null) return;

        Vector3 pos = transform.position;
        pos.x = target.position.x + offsetX;
        pos.y = target.position.y + offsetY;

        pos.x = Mathf.Clamp(pos.x, bounds.min.x, bounds.max.x);
        pos.y = Mathf.Clamp(pos.y, bounds.min.y, bounds.max.y);

        transform.position = pos;
    }

    void GetTilemapBounds()
    {
        if (tileMap == null) return;

        // Ÿ�ϸ��� �����ϴ� �ּ�, �ִ� �� ��ġ ��������
        BoundsInt cellBounds = tileMap.cellBounds;

        // �� ��ǥ�� ���� ��ǥ�� ��ȯ
        Vector3 minPos = tileMap.CellToWorld(cellBounds.min);
        Vector3 maxPos = tileMap.CellToWorld(cellBounds.max);

        minPos.x += camHalfWidth;
        minPos.y += camHalfHeight;
        maxPos.x -= camHalfWidth;
        maxPos.y -= camHalfHeight;

        // ī�޶� �̵��� ���� Bounds ����
        bounds = new Bounds();
        bounds.SetMinMax(minPos, maxPos);
    }
}
