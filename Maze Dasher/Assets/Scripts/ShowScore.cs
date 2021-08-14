using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    public Text Score;
    
    private void Start()
    {
     
    }
    // Start is called before the first frame update
    void Update()
    {
        int b = PlayerPrefs.GetInt("ScoreText") + 0;
        Score.text = b.ToString();
    }

    // Update is called once per frame
    
}
