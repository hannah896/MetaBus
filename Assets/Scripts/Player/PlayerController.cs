using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D _rigidbody;
    AnimationController animationController;

    [SerializeField] private float speed = 4.0f;

    BaseObject baseObject;
    
    Vector2 moveDirection;


    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        animationController = GetComponent<AnimationController>();
        _rigidbody.velocity = Vector3.zero;
    }

    //화면프레임기준
    private void Update()
    {
        //엔터를 누른다면 
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (baseObject == null) return;

            baseObject.Info();
        }
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //상호작용하는 물체일 때 
        if(collision.TryGetComponent(out BaseObject obj))
        {
            baseObject = obj;
            baseObject.AnnouncePanel.SetActive(true);
        }

        //캐릭터가 그라운드 존과 충돌할때
        //콜리전이 태그가 그라운드일때
        //플레이어 물리 중력 0
        if (collision.CompareTag("Ground"))
        {
            _rigidbody.gravityScale = 0;
            _rigidbody.AddTorque(-10f);
            _rigidbody.freezeRotation = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //상호작용 존 밖으로 벗어나려할때
        if (baseObject == null) return;
        baseObject.AnnouncePanel.SetActive(false);
        baseObject = null;
    }

    //물리처리프레임기준
    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal"); //수평 = 좌우 = a, d, <-, -> 입력을 받아옴
        float vertical = Input.GetAxisRaw("Vertical"); //수직 = 상하 = w, s, ↑, ↓ 입력을 받아옴

        //velocity 값
        moveDirection = new Vector2(horizontal, vertical);// 가로 세로 대각선의 속도를 똑같게 해줌 = 단위벡터 합이 무조건 1

        //입력된 값을 벡터로 바꿔야함
        int x;
        if (horizontal > 0.6f) x = 1;
        else if (horizontal < -0.6f) x = -1;
        else x = 0;

        int y;
        if (vertical > 0.6f) y = 1;
        else if (vertical < -0.6f) y = -1;
        else y = 0;

        //_rigidbody.velocity에서 이미 캐릭터가 움직이고 있다
        _rigidbody.velocity = moveDirection.normalized * speed;

        //애니메이터
        animationController.Move(new Vector2(horizontal * 3, vertical *3));
    }
}
