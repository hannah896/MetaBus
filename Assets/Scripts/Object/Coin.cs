using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Coin : MonoBehaviour
{
    float size = 1f;
    
    MinigameManager minigameManager;

    void Start()
    {
        size = Random.Range(0.3f, 1.5f);
        
        transform.localScale = new Vector3 (transform.localScale.x * size, transform.localScale.y, transform.localScale.z);
        minigameManager = MinigameManager.Instance;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("bottom"))
        {
            minigameManager.gameover = true;
            Time.timeScale = 0f;
        }
    }
}
