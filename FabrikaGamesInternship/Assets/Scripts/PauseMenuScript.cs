using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject PauseMenuButton;
    public void PauseButton()
    {
        PauseMenu.SetActive(true);
        PauseMenuButton.SetActive(false);
        Time.timeScale = 0;      

    }
    public void ResumeButton()
    {
        Time.timeScale = 1;
        PauseMenu.SetActive(false);
        PauseMenuButton.SetActive(true);

    }
    public void RetryButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
