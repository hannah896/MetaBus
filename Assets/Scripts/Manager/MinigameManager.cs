using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameManager : MonoBehaviour
{
    public static MinigameManager Instance;

    //���� ���� ���� ����
    public int CoinScore = 0;
    public bool gameover = false;
    public bool flag = true;
    public Vector3 position;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //�̴ϰ��� ���ӿ����Ǿ����� ���� ����
    public void SaveScore(string name)
    {
        PlayerPrefs.SetInt(name, CoinScore);
    }
}
