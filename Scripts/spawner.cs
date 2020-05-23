using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject toSpawn;

    private void spawn()
    {
        Instantiate(toSpawn);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            spawn();
        }
    }
}
