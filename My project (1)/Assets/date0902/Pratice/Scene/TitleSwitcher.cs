using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSwitcher : MonoBehaviour
{
    private const string SCENE_PLAY = "Play";

    private void Update()
    {
        ReadSceneKeys();
    }

    private void ReadSceneKeys()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            
            SceneManager.LoadScene(SCENE_PLAY);
            Debug.Log("TitleSwitcher: LoadScene 다음 줄입니다.");
        }
    }
}
