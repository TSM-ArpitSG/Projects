using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyStickMove : MonoBehaviour
{
    public float mspeed=5f;
    private Rigidbody2D rb;
    private float moveInput;
    [SerializeField]
    private Animator anim;
    public Joystick joystick;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        moveInput = joystick.Horizontal;
        rb.velocity = new Vector2(moveInput * mspeed, rb.velocity.y);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2.5f, 2.5f), transform.position.y, transform.position.z);
        if (moveInput == 0)
            anim.SetBool("Start", true);
        else
            anim.SetBool("Start", false);

        Vector3 characterScale = transform.localScale;
        if (joystick.Horizontal < 0)
        {
            characterScale.x = -1;
        }
        if (joystick.Horizontal > 0)
        {
            characterScale.x = 1;
        }
        transform.localScale = characterScale;


    }
}