using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class objectDestroyer : MonoBehaviour
{
    public int Score;
    public Text ScoreText;
    public Text LifeText;
    public Text WaveText;
    public int Life;
    public int level;
  
    


    void Start()
    {
        
        Score = 0;
        Life =3;
       
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
       
         Destroy(other.gameObject);
        if (other.gameObject.tag == "apple")
        {
            Score = Score + 10;
            ScoreText.text = "Score :" + Score.ToString();
           
        }
        else if (other.gameObject.tag == "banana")
        {
            Score = Score + 30;
            ScoreText.text = "Score :" + Score.ToString();
        }
        else if (other.gameObject.tag == "mellon")
        {
            Score = Score + 50;
            ScoreText.text = "Score :" + Score.ToString();
        }
        else if (other.gameObject.tag == "coin")
        {
            Score = Score + 500;
            ScoreText.text = "Score :" + Score.ToString();
        }
        else if (other.gameObject.tag == "bomb") {
           
            Life--;
            LifeText.text = "   " + Life.ToString();
        }
           
        
    }
   public void lifegone()
    {
        if (Life <= 0)
        {
           
            PlayerPrefs.SetInt("finalcomp", Score);
            SceneManager.LoadScene(4);
        }
        else
        {
            PlayerPrefs.SetInt("wave1score", 0+Score);
            PlayerPrefs.SetInt("Life1", Life);
        }
    }
    public void LoadWave2()
    {
        if (Score > 999)
            SceneManager.LoadScene("Wave2");
        
    }
    void Update()
    {
        lifegone();
        LoadWave2();
    }
}
