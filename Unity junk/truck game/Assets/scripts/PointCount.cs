using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.UI;

public class PointCount : MonoBehaviour
{
    public int numbercount, creditvalue = 3;
    public Text countertext;

    void OnTriggerEnter2D(Collider2D other)
    {
        numbercount += creditvalue;
        countertext.text = numbercount.ToString();
        gameObject.SetActive(false);
    }
}
