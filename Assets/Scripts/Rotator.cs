using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float r_Speed = 60f;
    void Update()
    {
        transform.Rotate(0f, r_Speed * Time.deltaTime, 0f);
    }
}