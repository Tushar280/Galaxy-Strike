using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] private GameObject exploVfx;

    private void OnTriggerEnter(Collider other)
    {
        Instantiate(exploVfx,transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}