using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class move : MonoBehaviour
{
    public Vector3 pos;
    float Speed = 0.2f;
    void Update()
    {
        if (Input.GetKey("w"))
            pos.z += Speed * Time.deltaTime;
    }
}
