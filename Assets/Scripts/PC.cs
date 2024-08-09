using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC : MonoBehaviour
{
    private Rigidbody pr;
    public float speed;

    void Start()
    {
        pr = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float xInput = Input.GetAxisRaw("Horizontal");
        float zInput = Input.GetAxisRaw("Vertical");

        pr.velocity = new Vector3(xInput, 0f, zInput).normalized * speed;
    }

    public void Die()
    {
        gameObject.SetActive(false);
    }
}
