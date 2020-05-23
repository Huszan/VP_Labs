using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 1.0f;
    public Material[] mat;
    public MeshRenderer mr;

    private void Start()
    {
        mr.material = mat[Random.Range(0, mat.Length)];
    }
    void Update()
    {
        float transX = Input.GetAxis("Mouse X") * speed * Time.deltaTime;
        float transY = Input.GetAxis("Mouse Y") * speed * Time.deltaTime;

        if (Input.GetMouseButton(0))
        {
            transform.Translate(transX, transY, 0);
        }
    }
}
