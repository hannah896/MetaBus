using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaderBoard : BaseObject
{
    public Text bestScoreTxt;

    public override void GameStart()
    {
        GameManager gameManager = GameManager.Instance;

        int bestScore = PlayerPrefs.GetInt(gameManager.playerCoinScore, -1);

        bestScoreTxt.text = $"{bestScore}";
    }
}
