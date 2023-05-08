using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
//using TMPro;



public class Level1_Script : MonoBehaviour
{
    public Level1_Script level1;
    public GameObject pauseMenuScreen;
        
    //public TPM_InputField inputField;
    public string player_name;
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
        //player_name = inputField.text;
        SceneManager.LoadSceneAsync("Quiz Level 1");
    }
    private void Awake()
    {
        if(level1 == null)
        {
            level1 = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
