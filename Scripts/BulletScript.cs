using UnityEngine;
using System.Collections;
using System.Security.Cryptography;

public class BulletScript : MonoBehaviour
{
    public float timeToDestroy = 6f;

    void delete()
    {
        Destroy(this.gameObject);
    }

    void Start()
    {
        Invoke("delete", timeToDestroy);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Terrain")
            Destroy(this.gameObject);
        if (collision.gameObject.tag == "Target")
            Destroy(this.gameObject);
    }
}
