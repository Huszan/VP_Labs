using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class spawner : MonoBehaviour
{
    private bool canSpawn = true;
    private float timer;

    public GameObject toSpawn;
    public float interval = 3f;

    private void spawn()
    {
        var pos = new Vector3(Random.Range(-80, 80), Random.Range(2, 20), Random.Range(-80, 80));
        Instantiate(toSpawn, pos, Quaternion.identity);
    }

    void Update()
    {
        if (timer >= 0.0f && canSpawn)
        {
            timer += Time.deltaTime;
        }
        if (timer >= interval)
        {
            spawn();
            timer = 0.0f;
        }

    }

}
