using UnityEngine;

public class GameManager : MonoBehaviour
{

    public readonly string playerCoinScore = "PlayerCoinScore";
    public readonly string playerDropScore = "playerDropScore";
    public readonly string minigameTag = "MinigameTrigger";
    public readonly string leaderBoardTag = "LeaderBoard";

    public static GameManager Instance;

    public GameObject ResultPanel;

    private void Awake()
    {
        Time.timeScale = 1.0f;
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //미니게임 상호작용
    public void InteractMiniGame(GameObject obj)
    {
        Fountain fountain = obj.GetComponent<Fountain>();
        fountain.Info();
    }

    public void InteractLeaderBoard(GameObject obj)
    {
        LeaderBoard board = obj.GetComponent<LeaderBoard>();
        board.Info();
    }
}
