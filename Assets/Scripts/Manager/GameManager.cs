using UnityEngine;

public class GameManager : MonoBehaviour
{

    public readonly string playerCoinScore = "PlayerCoinScore";
    public readonly string playerDropScore = "playerDropScore";
    public readonly string minigameTag = "MinigameTrigger";
    public readonly string leaderBoardTag = "LeaderBoard";

    public static GameManager Instance;

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
}
