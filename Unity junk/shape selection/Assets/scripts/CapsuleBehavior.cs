using UnityEngine;

public class CapsuleBehavior : MonoBehaviour
{
    public IntData num;

    private void OnTriggerEnter2D(Collider2D other)
    {
        num.number = 1;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        num.number = 0;
    }
    
}
