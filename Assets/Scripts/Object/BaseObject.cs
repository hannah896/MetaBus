using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class BaseObject : BasePortal
{
    public GameObject AnnouncePanel;

    public void Info()
    {
        if (AnnouncePanel == null) return;

        AnnouncePanel.SetActive(true);

        if (Input.GetKey(KeyCode.Return))
        {
            AnnouncePanel.SetActive(false);
            //�̴ϰ��� �ҷ�����
            GameStart();
        }
    }

    public abstract void GameStart();
}
