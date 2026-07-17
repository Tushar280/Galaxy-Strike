using UnityEngine;

public class ParticleCollision : MonoBehaviour
{
    [SerializeField] private GameObject exploVfx;
    [SerializeField] private int hitPoints = 10;
    [SerializeField]private ScoreBoard scoreBoard;

    private void Start()
    {
        scoreBoard = FindObjectOfType<ScoreBoard>();
    }

    private void OnParticleCollision(GameObject other)
    {
        hitPoints --;
        ProcsessHit();
        scoreBoard.AddScore(1);
    }

    private void ProcsessHit()
    {
        if(hitPoints <= 0){

            Instantiate(exploVfx,transform.position, Quaternion.identity);
            Destroy(gameObject);

        }
    }
}
