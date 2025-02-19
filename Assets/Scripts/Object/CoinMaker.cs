using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics;

public class CoinMaker : MonoBehaviour
{
    public GameObject coin;
    MinigameManager minigameManager;

    private void Start()
    {
        minigameManager = MinigameManager.Instance;
    }

    private void Update()
    {
        if (minigameManager.gameover) return;

        Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        transform.position = new Vector3(MousePos.x, 3f, 0);

        if (Input.GetMouseButtonUp(0))
        {
            minigameManager.position = new Vector3(MousePos.x, 3f, 0);
            minigameManager.flag = false;
            MakeCoin();
            minigameManager.CoinScore++;
        }
    }

    private void MakeCoin()
    {
        Vector2 pos = minigameManager.position;
        Instantiate(coin, pos, Quaternion.identity);
        minigameManager.flag = true;
    }
}
