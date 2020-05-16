using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s1 : MonoBehaviour
{
    private GameObject[] go;
    void Start()
    {
        go = GameObject.FindGameObjectsWithTag("kula");
        for(int i = 0; i < go.Length; i++)
        {
            Destroy(go[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
