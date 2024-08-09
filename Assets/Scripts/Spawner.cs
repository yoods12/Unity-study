using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject bullet;
    public float s_Min = 1f;
    public float s_Max = 3f;

    private Transform target;
    private float s_Rate;
    private float timeAfterSpawn;
    void Start()
    {
        timeAfterSpawn = 0f;

        s_Rate = Random.Range(s_Min, s_Max);

        target = FindObjectOfType<PC>().transform;
    }

    void Update()
    {
        timeAfterSpawn = timeAfterSpawn + Time.deltaTime;

        if (timeAfterSpawn > s_Rate)
        {
            timeAfterSpawn = 0f;
            GameObject b= Instantiate(bullet, transform.position, transform.rotation);
            b.transform.LookAt(target);
            s_Rate = Random.Range(s_Min, s_Max);
        }
    }
}
