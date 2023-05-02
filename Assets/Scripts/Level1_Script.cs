using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;


public class Level1_Script : MonoBehaviour
{
    public GameObject pauseMenuScreen;
    //public inputField playername; 
    public void PauseButton()
    {
        Time.timeScale = 0;
        pauseMenuScreen.SetActive(true);
    }
    public void ResumeButton()
    {
        Time .timeScale = 1;
        pauseMenuScreen.SetActive(false);
    }
    public void SetPlayerName()
    {
        //playername = inputField.text;
        SceneManager.LoadScene(2);
    }
}
