
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public GameObject firePoint;

    public float bulletSpeed = 50f;

    public void shoot()
    {
        this.gameObject.GetComponent<AudioSource>().Play();
        GameObject newBullet = Instantiate(bullet, firePoint.transform.position, firePoint.transform.rotation);
        newBullet.GetComponent<Rigidbody>().velocity = transform.TransformDirection(new Vector3(-bulletSpeed, 0, 0));
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            shoot();
        }
    }
}
