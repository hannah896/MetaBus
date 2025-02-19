using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class BaseObject : MonoBehaviour
{
    public GameObject AnnouncePanel;

    public void Info()
    {
        if (AnnouncePanel == null) return;

        AnnouncePanel.SetActive(true);

        if (Input.GetKeyUp(KeyCode.Return))
        {
            AnnouncePanel.SetActive(false);
            //미니게임 불러오기
            GameStart();
        }
        AnnouncePanel.SetActive(false);
    }

    public abstract void GameStart();
}
