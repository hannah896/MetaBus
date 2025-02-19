using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MinigameManager : MonoBehaviour
{
    public static MinigameManager Instance;

    //���� ���� ���� ����
    public int CoinScore = 0;
    public bool gameover = false;
    public bool flag = true;
    public bool isExit = false;
    public bool isSave = false;
    public Vector3 position;

    //�Է¹��� ���ڵ�
    [SerializeField] public GameObject ResultPanel;

    [SerializeField] public Text ScoreTxt;
    [SerializeField] public Text CurrentScoreTxt;

    [SerializeField] private GameManager gameManager;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
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
        CurrentScoreTxt.text = CoinScore.ToString();
        if ((gameover) && (!isExit))
        {
            ResultPanel.SetActive(true);
            ScoreTxt.text = $"{CoinScore}";
            if (!isSave)
            {
                SaveScore();
            }
        }
            
        else if ((gameover) && (isExit))
        {
            SceneManager.LoadScene(0);
        }
    }

    //�̴ϰ��� ���ӿ����Ǿ����� ���� ����
    private void SaveScore()
    {
        string name = gameManager.playerCoinScore;
        int bestScore = PlayerPrefs.GetInt(name);

        PlayerPrefs.SetInt(name, CoinScore > bestScore ? CoinScore : bestScore);
        isSave = true;
    }
}
