using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameManager : MonoBehaviour
{
    public static MinigameManager Instance;

    //코인 게임 저장 변수
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

    //미니게임 게임오버되었을때 점수 저장
    private void SaveScore()
    {
        name = gameManager.playerCoinScore;
        PlayerPrefs.SetInt(name, CoinScore);
    }
}
