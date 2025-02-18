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
        float horizontal = Input.GetAxisRaw("Horizontal"); //수평 = 좌우 = a, d, <-, -> 입력을 받아옴
        float Vertical = Input.GetAxisRaw("Vertical"); //수직 = 상하 = w, s, ↑, ↓ 입력을 받아옴

        Vector2 moveDirection = new Vector2(horizontal, Vertical).normalized; // 가로 세로 대각선의 속도를 똑같게 해줌 = 단위벡터 합이 무조건 1

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
