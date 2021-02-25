using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Detection : MonoBehaviour
{
    public TextScript words;

    private void OnTriggerEnter2D(Collider2D other)
    {
        words.words.text = "lol";
    }
}
