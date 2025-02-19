using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    float size = 1f;
    int score = 1;
    bool flag = true;
    bool gameover = false;
    // Start is called before the first frame update
    void Start()
    {
        size = Random.Range(1f, 3.7f);
    }

    // Update is called once per frame
    void Update()
    {
        if (flag)
        {
            Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            transform.position = new Vector3(MousePos.x, 3f, 0);

            if (Input.GetMouseButtonUp(0))
            {
                transform.position = new Vector3(MousePos.x, 3f, 0);
                flag = false;
            }
        }
        else
        {
            string name = GameManager.Instance.playerCoinScore;

            if (gameover)
            {
                score = GameManager.Instance.CoinScore;
                PlayerPrefs.SetInt(name, score);
            }
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("bottom"))
        {
            gameover = true;
            Debug.Log("게임오버!");
        }
    }
}
