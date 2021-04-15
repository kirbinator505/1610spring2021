using UnityEngine;

public class Detection : MonoBehaviour
{
    public StringData word;

    private int number;
    private GameObject shape;
    
    private void Update()
    {
        if (number == 1)
        { 
           word.shape = "the capsule";
        }
        else if (number == 2)
        {
           word.shape = "the hexagon";
        }
        else if (number == 3)
        {
           word.shape = "the square";
        }
        else if (number == 0)
        {
            word.shape = "nothing";
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        shape = other.gameObject;
        number = shape.GetComponent<IntegerAssignment>().value;
    }

    private void OnTriggerExit2D()
    {
        number = 0;
    }
}
