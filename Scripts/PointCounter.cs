using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointCounter : MonoBehaviour
{
    public Text textBox;
    public int numberOfPoints = 0;

    public void Update()
    {
        textBox.text = numberOfPoints.ToString();
    }
}
