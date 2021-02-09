using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointCount : MonoBehaviour
{
    public int creditvalue = 3;
    public int numbercount;
    public Text countertext;

    void OnTriggerEnter2D(Collider2D other)
    {
        numbercount += creditvalue;
        countertext.text = numbercount.ToString();
        gameObject.SetActive(false);
    }
}
