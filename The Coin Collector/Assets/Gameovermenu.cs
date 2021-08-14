using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Gameovermenu : MonoBehaviour
{
    public void PlayGame1(string level)
    {
        SceneManager.LoadScene(level);
    }
    public void QuitGame1()
    {
        Application.Quit();
    }
}

