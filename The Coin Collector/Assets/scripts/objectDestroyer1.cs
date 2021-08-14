using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class objectDestroyer1 : MonoBehaviour
{
    int Score;
    public Text ScoreText;
    public Text LifeText;
    
    int Life;
    public int level;
    


    void Start()
    {

      
        Score = PlayerPrefs.GetInt("wave1score"); ;
        Life = PlayerPrefs.GetInt("Life1");
        ScoreText.text = "Score :" + Score.ToString();
        LifeText.text = "   "+ Life.ToString();
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //add animator

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
            LifeText.text = "   " +Life.ToString();
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
            PlayerPrefs.SetInt("wave2score", 0+Score);
            PlayerPrefs.SetInt("Life2", Life);
        }
    }
    public void LoadWave3()
    {
        if (Score > 1999)
            SceneManager.LoadScene("Wave3");
       
       
    }
    void Update()
    {
        lifegone();
        LoadWave3();
    }
}
