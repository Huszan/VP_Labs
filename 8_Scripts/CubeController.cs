using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public float speed = 1f;
    public enum ChooseVector { X,Y,Z}
    public ChooseVector chooseVector;

    void Update()
    {
        if (chooseVector == ChooseVector.X) this.transform.Rotate(speed, 0, 0, Space.Self);
        else if (chooseVector == ChooseVector.Y) this.transform.Rotate(0, speed, 0, Space.Self);
        else if (chooseVector == ChooseVector.Z) this.transform.Rotate(0, 0, speed, Space.Self);
    }
}
