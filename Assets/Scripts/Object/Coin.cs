using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Coin : MonoBehaviour
{
    float size = 1f;
    int score = 1;
    
    MinigameManager minigameManager;

    void Start()
    {
        size = Random.Range(1f, 3.7f);
        minigameManager = MinigameManager.Instance;
    }

    void Update()
    {
        if (minigameManager.gameover)
        {
            score = minigameManager.CoinScore;
            PlayerPrefs.SetInt(name, score);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("bottom"))
        {
            minigameManager.gameover = true;
            Debug.Log("게임오버!");
        }
    }
}
