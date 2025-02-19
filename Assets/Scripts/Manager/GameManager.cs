using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{

    public readonly string playerCoinScore = "playerCoinScore";
    public readonly string playerDropScore = "playerDropScore";
    public readonly string minigameTag = "MinigameTrigger";

    public static GameManager Instance;
    private void Awake()
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

    private int coinScore = 0;
    public int CoinScore
    {
        get { return coinScore; }
        set { coinScore = value; }
    }

    //������Ʈ�� ��ȣ�ۿ�
    public void Interact(GameObject obj)
    {
        Fountain fountain = obj.GetComponent<Fountain>();
        fountain.Info();
    }

    //�̴ϰ��� ���ӿ����Ǿ����� ���� ����
    public void SaveScore(string name)
    {
        PlayerPrefs.SetInt(name, coinScore);
    }
}
