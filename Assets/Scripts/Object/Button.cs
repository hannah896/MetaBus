using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void Exit()
    {
        Debug.Log("Á×À»°Ô ^_^");
        MinigameManager.Instance.isExit = true;
    }
}
