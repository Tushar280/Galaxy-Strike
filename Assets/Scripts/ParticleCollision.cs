using UnityEngine;

public class ParticleCollision : MonoBehaviour
{
    [SerializeField] private GameObject exploVfx;
    [SerializeField] private int hitPoints = 10;
    [SerializeField] private int destroyScore = 100;
    [SerializeField] private int hitScore = 10;
    [SerializeField]private ScoreBoard scoreBoard;

    private void Start()
    {
        scoreBoard = FindFirstObjectByType<ScoreBoard>();
    }

    private void OnParticleCollision(GameObject other)
    {
        hitPoints --;
        ProcsessHit();
        scoreBoard.AddScore(hitScore);
    }

    private void ProcsessHit()
    {
        if(hitPoints <= 0){

            Instantiate(exploVfx,transform.position, Quaternion.identity);
            Destroy(gameObject);
            scoreBoard.AddScore(destroyScore);
        }
    }
}
