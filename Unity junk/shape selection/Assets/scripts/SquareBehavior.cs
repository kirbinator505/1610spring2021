using UnityEngine;

public class SquareBehavior : MonoBehaviour
{
    public IntData num;

    private void OnTriggerEnter2D(Collider2D other)
    {
        num.number = 3;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        num.number = 0;
    }
}
