using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMaker : MonoBehaviour
{
    public GameObject coin;

    private void Start()
    {
        
    }

    private void MakeCoin(Vector2 mousePos)
    {
        Instantiate(coin);
    }
}
