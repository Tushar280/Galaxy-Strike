using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private int reloadTime = 2;

    public void ReloadScene()
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index);
    }
    
    IEnumerator ReloadAfterSec(int time)
    {
        yield return new WaitForSeconds(reloadTime);
    }

}
