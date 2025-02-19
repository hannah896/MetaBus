using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject obj = new GameObject("GameManager");
                instance = obj.AddComponent<GameManager>();
                DontDestroyOnLoad(obj);
            }
            return instance;
        }
    }

    private int coinScore = 0;
    public int CoinScore
    {
        get { return coinScore; }
        set { coinScore = value; }
    }

    public GameObject Panel;

    public readonly string playerCoinScore = "playerCoinScore";
    public readonly string playerDropScore = "playerDropScore";

    //오브젝트와 상호작용
    public void Interact(GameObject obj)
    {

        if (obj.CompareTag("MiniGameTrigger"))
        {
            Fountain fountain = obj.GetComponent<Fountain>();
            fountain.Info();
        }
    }

    //미니게임 게임오버되었을때 점수 저장
    public void SaveScore(string name)
    {
        PlayerPrefs.SetInt(name, coinScore);
    }
}
