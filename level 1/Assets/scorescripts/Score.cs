using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score;
    public Text ScoreText;
    
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerEnter (Collider other)
    {
         
        if (other.gameObject.tag == "Player")
         {
            AddScore();
        
            
         }

    }
    void AddScore()
    {
        score += 100;
        ScoreText.text = "SCORE :"+score.ToString();
        PlayerPrefs.SetString("Scoretrt", score.ToString());
    }

 
}
