using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class destroyplayer : MonoBehaviour
{
    public GameObject player;
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
         Destroy(other.gameObject);
        SceneManager.LoadScene("Score");
        StartCoroutine("WaitForSec");
        ;
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(0.1f);
       
        
    }
}
