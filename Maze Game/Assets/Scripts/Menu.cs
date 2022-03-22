using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    //Makes play button load scene from build settings
    public void Play() 
    {
        SceneManager.LoadScene(1);

    }

    //Makes return button load scene from build settings
    public void Return() 
    {
        SceneManager.LoadScene(0);

    }

    //Makes exit button quit the application
    public void Exit() 
    {
        Application.Quit();
    }
}
