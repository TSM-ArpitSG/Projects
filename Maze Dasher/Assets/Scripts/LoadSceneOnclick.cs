using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnclick : MonoBehaviour
{

    public void LoadSceneOnClicl(int level)
    {
        SceneManager.LoadScene(level);
    }



}

