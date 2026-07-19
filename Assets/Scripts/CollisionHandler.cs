using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] private GameObject exploVfx;
    private SceneLoader sceneLoader;

    private void Start()
    {
        sceneLoader = FindFirstObjectByType<SceneLoader>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Instantiate(exploVfx,transform.position, Quaternion.identity);
        Destroy(gameObject);
        sceneLoader.ReloadScene();
    }
}