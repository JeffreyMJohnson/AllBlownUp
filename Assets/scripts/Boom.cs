using UnityEngine;
using System.Collections;

public class Boom : MonoBehaviour
{
    public float force;
    public float radius;

    public void DoIt()
    {
        Rigidbody rBody = transform.parent.GetComponent<Rigidbody>();
        Debug.Log("Boom");
        rBody.AddExplosionForce(force, transform.position, radius, 0, ForceMode.Impulse);
        Destroy(gameObject);
    }

}
