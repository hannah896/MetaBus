using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fountain : BaseObject
{
    public override void GameStart()
    {
        //동전미니게임 로드
        SceneManager.LoadScene("CoinMiniGameScene");
    }
}
