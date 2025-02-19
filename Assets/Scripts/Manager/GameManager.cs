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

    //������Ʈ�� ��ȣ�ۿ�
    public void Interact(GameObject obj)
    {

        if (obj.CompareTag("MiniGameTrigger"))
        {
            Fountain fountain = obj.GetComponent<Fountain>();
            fountain.Info();
        }
    }

    //�̴ϰ��� ���ӿ����Ǿ����� ���� ����
    public void SaveScore(string name)
    {
        PlayerPrefs.SetInt(name, coinScore);
    }
}
