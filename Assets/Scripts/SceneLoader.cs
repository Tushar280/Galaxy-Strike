using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private int waitSeconds = 2;

    public void ReloadScene()
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index);
    }
    


}
