using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    //애니메이터 선언
    protected Animator animator;

    //애니메이터 파라미터의 아이디값을 먼저 받음
    private static readonly int IsWalk = Animator.StringToHash("IsWalk");

    //블랜더트리의 MoveX, MoveY의 아이디값
    private static readonly int MoveX = Animator.StringToHash("MoveX");
    private static readonly int MoveY = Animator.StringToHash("MoveY");

    private static bool iswalk;

    protected virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>();
    }

    public void Move(Vector2 value)
    {
        //플레이어가 걷기를 멈췄을때 경우
        if (value.magnitude == 0)
        {
            animator.SetBool(IsWalk, false);
        }
        //플레이어가 걸었을때
        else
        {
            animator.SetBool(IsWalk, true);
            animator.SetFloat(MoveX, value.x);
            animator.SetFloat(MoveY, value.y);
        }
    }
}
