using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platformcollision : MonoBehaviour
{
    public Animator anim;
    void Start()
    {
        //anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       Destroy(other.gameObject);
       //anim.Play("platformanim");
    }
    void Update()
    {
        
    }
}
