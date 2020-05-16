using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    private bool canSpawn = true;
    private float timer;

    public GameObject[] objectList;
    public float interval = 3f;

    private void spawn(int number)
    {
        Instantiate(objectList[number], this.transform);
    }

    void Update()
    {
        if (timer >= 0.0f && canSpawn)
        {
            timer += Time.deltaTime;
        }
        if (timer >= interval)
        {
            spawn(Random.Range(0, objectList.Length - 1));
            timer = 0.0f;
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (canSpawn) canSpawn = false;
            else canSpawn = true;
            Debug.Log("Can spawn = " + canSpawn);
        }
        if (Input.GetKeyDown(KeyCode.Space)) spawn(Random.Range(0, objectList.Length - 1));
        if (Input.GetKeyDown(KeyCode.Alpha1)) spawn(0);
        if (Input.GetKeyDown(KeyCode.Alpha2)) spawn(1);
        if (Input.GetKeyDown(KeyCode.Alpha3)) spawn(2);
        if (Input.GetKeyDown(KeyCode.Alpha4)) spawn(3);
        if (Input.GetKeyDown(KeyCode.Alpha5)) spawn(4);
    }

}
