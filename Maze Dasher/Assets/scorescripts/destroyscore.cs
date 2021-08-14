using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyscore : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            Destroy(this.gameObject);
        }
    }
}
