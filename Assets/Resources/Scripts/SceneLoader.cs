using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class SceneLoader: MonoBehaviour
{
    public void NormalButton()
    {
        SceneManager.LoadScene("Normal");
    }
   
    public void UbungButton()
    {
        SceneManager.LoadScene("Ubung");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
