using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class objectDestroyer2 : MonoBehaviour
{
    int Score;
    public Text ScoreText;
    public Text LifeText;
 
    int Life;
    public int level;
    int Wave;

    void Start()
    {
       
        Score = PlayerPrefs.GetInt("wave2score"); ;
        Life = PlayerPrefs.GetInt("Life2");
        ScoreText.text = "Score :" + Score.ToString();
        LifeText.text = "   " + Life.ToString();
        
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
           
            PlayerPrefs.SetInt("wave3score", 0+Score);
            PlayerPrefs.SetInt("Life3", Life);
        }
    }
    public void LoadWave3()
    {

        if (Score > 2999)
        {
            PlayerPrefs.SetInt("finalcomp", Score);
            SceneManager.LoadScene("WInner");
        }
    }
    void Update()
    {
       
        lifegone();
        LoadWave3();
      
    }
}
