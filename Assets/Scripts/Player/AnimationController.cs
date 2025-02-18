using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    //�ִϸ����� ����
    protected Animator animator;

    //�ִϸ����� �Ķ������ ���̵��� ���� ����
    private static readonly int IsWalk = Animator.StringToHash("IsWalk");

    //����Ʈ���� MoveX, MoveY�� ���̵�
    private static readonly int MoveX = Animator.StringToHash("MoveX");
    private static readonly int MoveY = Animator.StringToHash("MoveY");

    private static bool iswalk;

    protected virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>();
    }

    public void Move(Vector2 value)
    {
        //�÷��̾ �ȱ⸦ �������� ���
        if (value.magnitude == 0)
        {
            animator.SetBool(IsWalk, false);
        }
        //�÷��̾ �ɾ�����
        else
        {
            animator.SetBool(IsWalk, true);
            animator.SetFloat(MoveX, value.x);
            animator.SetFloat(MoveY, value.y);
        }
    }
}
