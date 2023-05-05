using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartButtonScript : MonoBehaviour
{
    public int gameStartScreen;
    
    public void StartGame_function()
    {
        SceneManager.LoadScene(gameStartScreen);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
