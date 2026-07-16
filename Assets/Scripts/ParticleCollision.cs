using UnityEngine;

public class ParticleCollision : MonoBehaviour
{
    [SerializeField] private GameObject exploVfx;

    private void OnParticleCollision(GameObject other)
    {
        Instantiate(exploVfx,transform.position, Quaternion.identity);
        
        Destroy(gameObject);
    }
}
