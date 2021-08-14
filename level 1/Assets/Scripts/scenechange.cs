using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenechange : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
     void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject== Player)
        {
            SceneManager.LoadScene("Win Screen");
        }
    }
}
