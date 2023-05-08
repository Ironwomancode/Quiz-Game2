using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScript : MonoBehaviour
{
    public GameObject RulesMenuScreen;
    // Start is called before the first frame update
    public void RulesButton()

    {
        Time.timeScale = 0;
        RulesMenuScreen.SetActive(true);
    }

    // Update is called once per frame
    public void ResumeButton()
    {
        Time.timeScale = 1;
        RulesMenuScreen.SetActive(false);
    }
}
