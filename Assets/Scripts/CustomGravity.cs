using UnityEngine;

public class CustomGravity : MonoBehaviour
{
    public Transform center;
    public float gravity = 9.8f;

    void FixedUpdate()
    {
        Vector3 dir = (center.position - transform.position).normalized;
        GetComponent<Rigidbody>().AddForce(dir * gravity);
    }
}