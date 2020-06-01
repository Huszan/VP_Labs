using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionTarget : MonoBehaviour
{
    public float timeToDestroy = 1f;
    private bool canGivePoints = true;
    void deleteWithInterval()
    {
        Destroy(this.gameObject);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && canGivePoints)
        {
            this.gameObject.GetComponent<AudioSource>().Play();
            GameObject gm = GameObject.Find("_GameManager");
            gm.GetComponent<PointCounter>().numberOfPoints += 1;
            canGivePoints = false;
            Invoke("deleteWithInterval", timeToDestroy);
        }
    }
}
