using UnityEngine;

public class HexBehavior : MonoBehaviour
{
    public IntData num;

    private void OnTriggerEnter2D(Collider2D other)
    {
        num.number = 2;
    }
}