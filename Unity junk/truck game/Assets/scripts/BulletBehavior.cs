using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class BulletBehavior : MonoBehaviour
{
    private Rigidbody bulletRB;
    public float bulletforce = 10f;
    private Vector3 forces;

    void Start()
    {
        bulletRB = GetComponent<Rigidbody>();
        forces.Set(bulletforce, 0 ,0);
        bulletRB.AddRelativeForce(forces);
    }

}
