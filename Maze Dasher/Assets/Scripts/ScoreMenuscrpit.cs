using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreMenuscrpit : MonoBehaviour
{
    // Start is called before the first frame update
    public void quit() 
    {
        Application.Quit();
    }
    public void Menu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void Retry()
    {
        SceneManager.LoadScene("level 1");
    }
    
}
