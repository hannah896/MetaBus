using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D _rigidbody;
    AnimationController animationController;

    [SerializeField] private float speed = 4.0f;

    private void Awake()
    {
        Camera camera = Camera.main;
        _rigidbody = GetComponent<Rigidbody2D>();
        animationController = GetComponent<AnimationController>();
        _rigidbody.velocity = Vector3.zero;
    }

    //ȭ�������ӱ���
    private void Update()
    {
        
    }

    //����ó�������ӱ���
    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal"); //���� = �¿� = a, d, <-, -> �Է��� �޾ƿ�
        float vertical = Input.GetAxisRaw("Vertical"); //���� = ���� = w, s, ��, �� �Է��� �޾ƿ�

        //velocity ��
        Vector2 moveDirection = new Vector2(horizontal, vertical);// ���� ���� �밢���� �ӵ��� �Ȱ��� ���� = �������� ���� ������ 1


        //�Էµ� ���� ���ͷ� �ٲ����
        int x;
        if (horizontal > 0.6f) x = 1;
        else if (horizontal < -0.6f) x = -1;
        else x = 0;

        int y;
        if (vertical > 0.6f) y = 1;
        else if (vertical < -0.6f) y = -1;
        else y = 0;

        //_rigidbody.velocity �̹� ĳ���Ͱ� �����̰� �ִ�
        _rigidbody.velocity = moveDirection.normalized * speed;

        //�ִϸ�����
        animationController.Move(new Vector2(horizontal * 3, vertical *3));
    }
}
