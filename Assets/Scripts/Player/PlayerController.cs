using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    private float velocity = 0.005f;

    private void Start()
    {
        Camera camera = Camera.main;
    }

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal"); //���� = �¿� = a, d, <-, -> �Է��� �޾ƿ�
        float Vertical = Input.GetAxisRaw("Vertical"); //���� = ���� = w, s, ��, �� �Է��� �޾ƿ�

        Vector2 moveDirection = new Vector2(horizontal, Vertical).normalized; // ���� ���� �밢���� �ӵ��� �Ȱ��� ���� = �������� ���� ������ 1

        Move(moveDirection);
    }

    private void Move(Vector2 direction)
    {
        Transform transform = this.GetComponent<Transform>();

        float valueX = transform.localPosition.x + direction.x * velocity;
        float valueY = transform.localPosition.y + direction.y * velocity;

        this.transform.position = new Vector2 (valueX, valueY);
    }
}
