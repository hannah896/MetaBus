using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D _rigidbody;
    AnimationController animationController;

    [SerializeField] private float speed = 4.0f;

    GameManager gameManager;

    bool isContact = false;

    Vector2 moveDirection;


    private void Awake()
    {
        Camera camera = Camera.main;
        _rigidbody = GetComponent<Rigidbody2D>();
        animationController = GetComponent<AnimationController>();
        _rigidbody.velocity = Vector3.zero;
        gameManager = GameManager.Instance;
    }

    //화면프레임기준
    private void Update()
    {
        //엔터를 누른다면 
        if (Input.GetKeyDown(KeyCode.Return))
        {
            isContact = true;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)  
    {
        if (isContact == false) return;

        GameObject col = collision.gameObject;

        //아이템 오브젝트와 상호작용
        if (col.CompareTag(gameManager.minigameTag))
        {
            gameManager.InteractMiniGame(col);
        }

        //아이템 리더보드랑 상호작용
        if (col.CompareTag(gameManager.leaderBoardTag))
        {
            gameManager.InteractLeaderBoard(col);
        }
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
