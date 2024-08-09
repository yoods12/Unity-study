using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed;
    private Rigidbody brb;
    void Start()
    {
        brb = GetComponent<Rigidbody>();

        brb.velocity = transform.forward * speed;

        Destroy(gameObject, 3f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PC pc = other.GetComponent<PC>();
            if (pc != null) 
            { 
                pc.Die();
            }
        }
    }

    void Update()
    {
        
    }
}
