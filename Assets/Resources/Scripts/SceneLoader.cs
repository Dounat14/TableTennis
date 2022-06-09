using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class SceneLoader: MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("Normal");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
