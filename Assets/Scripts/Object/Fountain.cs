using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fountain : BaseObject
{
    public override void GameStart()
    {
        //�����̴ϰ��� �ε�
        SceneManager.LoadScene("CoinMiniGameScene");
    }
}
