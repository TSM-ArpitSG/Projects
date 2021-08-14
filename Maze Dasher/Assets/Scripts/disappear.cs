using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disappear : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="Player")
        {
            _ = StartCoroutine(routine: TimeToWait());
        }
    }
    IEnumerator TimeToWait()
    {
        yield return new WaitForSeconds(.1f);
        Destroy(this.gameObject);
    }
}
