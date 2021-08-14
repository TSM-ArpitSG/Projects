using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text Final;
    int Score;
    void Start()
    {
        Score  = PlayerPrefs.GetInt("finalcomp");
        if (Score < 999)
            Final.text = Score.ToString();
        else if (Score < 1999)
            Final.text = Score.ToString();
        else if (Score>2999)
        {
           
            Final.text = Score.ToString();
        }
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
