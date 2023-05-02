using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LoadingBar : MonoBehaviour
{
    private Slider slider;
    private float Targetprogress = 0;
    public float fillSpeed = 0.5f;

    private void Awake()
    {
        slider = GetComponent<Slider>(); 
    }
    void Start()
    {
        incrementProgress(0.9f);
    }
    // Update is called once per frame
    void Update()
    {
        if (slider.value < Targetprogress)
        {
            slider.value += fillSpeed * Time.deltaTime;
        }
        else
        {
            SceneManager.LoadScene(2);
        }
        
    }
    public void incrementProgress(float newProgress)
    {
        Targetprogress = slider.value + newProgress;
    }
}
