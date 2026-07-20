using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private int reloadTime = 2;

    public void ReloadScene()
    {
        StartCoroutine(ReloadAfterSec());
    }
    
    IEnumerator ReloadAfterSec(int time)
    {
        yield return new WaitForSeconds(reloadTime);
        int index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index);
    }

}
