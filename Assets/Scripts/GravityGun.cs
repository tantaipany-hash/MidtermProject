using UnityEngine;

public class GravityGun : MonoBehaviour
{
    public float forcePower = 20f;
    public Camera cam;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            Rigidbody rb = hit.collider.GetComponent<Rigidbody>();

            if (rb != null)
            {
                float mass = rb.mass;
                Vector3 force = ray.direction * forcePower * mass;

                rb.AddForce(force);
            }
        }
    }
}