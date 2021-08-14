using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class displaytext : MonoBehaviour
{
    
    public GameObject uiObject;
    static int inc=100;
    public int score;
    public Text ScoreText;
     
    
    private void Start()
    {
      
        uiObject.SetActive(false);
        PlayerPrefs.SetInt("ScoreText", 0);
        PlayerPrefs.SetInt("c", 0);
        score = 0;
        
    }
   void OnTriggerEnter(Collider player)
    { 
        
        if(player.gameObject.tag=="Player")
        {
           uiObject.SetActive(true);   
        

           StartCoroutine("WaitForSec");
          
        }
    
    }
  
    IEnumerator WaitForSec()
    {
        
        yield return new WaitForSeconds(3.5f); 
        Destroy(uiObject);
        Destroy(gameObject);
        score = score + inc + PlayerPrefs.GetInt("c");
        ScoreText.text = "Score:" + score.ToString();
        PlayerPrefs.SetInt("c",score);
        PlayerPrefs.SetInt("ScoreText", score);

    }
    
}
