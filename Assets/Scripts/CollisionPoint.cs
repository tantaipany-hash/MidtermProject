using UnityEngine;

public class CollisionCheck : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("ชน: " + col.gameObject.name);
    }
}