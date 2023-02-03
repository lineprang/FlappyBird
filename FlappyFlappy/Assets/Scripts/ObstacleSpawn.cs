using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    public float queueTime = 1.5f;
    private float time = 0;
    public GameObject obstacle;

    public float height;
    void Update()
    {
        if (time > queueTime)
        {
            Instantiate(obstacle, new Vector3(12, Random.Range(-height, height), 0), Quaternion.identity);
            time = 0;
        }

        time += Time.deltaTime;
    }
}
