using UnityEngine;

public class ParticleCollision : MonoBehaviour
{
    [SerializeField] private GameObject exploVfx;
    [SerializeField] private int hitPoints = 10;

    private void OnParticleCollision(GameObject other)
    {
        hitPoints --;

        if(hitPoints <= 0){

            Instantiate(exploVfx,transform.position, Quaternion.identity);
            Destroy(gameObject);

        }
    }
}
