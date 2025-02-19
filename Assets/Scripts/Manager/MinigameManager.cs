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

    private GameManager gameManager;

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

    private void Start()
    {
        gameManager = GameManager.Instance;
    }
    private void Update()
    {
        if (gameover == true)
        {
            SaveScore();
        }
    }

    //�̴ϰ��� ���ӿ����Ǿ����� ���� ����
    private void SaveScore()
    {
        name = gameManager.playerCoinScore;
        PlayerPrefs.SetInt(name, CoinScore);
    }
}
