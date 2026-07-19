using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private int waitSeconds = 2;

    public void ReloadScene()
    {
        int index = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
        UnityEngine.SceneManagement.SceneManager.LoadScene(index);
    }
    


}
