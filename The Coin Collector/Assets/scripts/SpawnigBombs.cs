using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnigBombs : MonoBehaviour
{
    public GameObject BombPrefab;
    public float respawntime = 5f;
    private Vector2 screenBounds;
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(BombWave());    
    }
    private void spawnBomb()
    {
        GameObject a = Instantiate(BombPrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x*-.5f, screenBounds.x),screenBounds.y*1);
    }
 
    IEnumerator BombWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawntime);
            spawnBomb();
        }
    }
}
