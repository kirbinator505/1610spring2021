using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDuplicator : MonoBehaviour
{
    public GameObject ball;
    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            Instantiate(ball);
        }
    }
}
