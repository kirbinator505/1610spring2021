using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Detection : MonoBehaviour
{
    public IntData num;
    public StringData word;
    private void Update()
    {
        if (num.number == 1)
        {
            word.shape = "Capsule";
        }
        if (num.number == 2)
        {
            word.shape = "Hexagon";
        }
        if (num.number == 3)
        {
            word.shape = "Square";
        }
    }
}
