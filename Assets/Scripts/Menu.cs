using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;                          

public class Menu : MonoBehaviour
{
    public GameObject RestartMenuPause;

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void PauseGame()
    {
        RestartMenuPause.SetActive(true);
        Time.timeScale = 0f;
    }

    public void PlayGame()
    {
        RestartMenuPause.SetActive(false);
        Time.timeScale = 1f;
    }

}
