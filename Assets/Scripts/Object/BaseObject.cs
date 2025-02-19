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
            //�̴ϰ��� �ҷ�����
            GameStart();
        }
        AnnouncePanel.SetActive(false);
    }

    public abstract void GameStart();
}
