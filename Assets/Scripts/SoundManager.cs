using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private void Start()
    {
    int numOfMusicPlayers = FindObjectsByType<SoundManager>(FindObjectsSortMode.None).Length;

    if(numOfMusicPlayers > 1)
    {
        Destroy(gameObject);
    }
    else
    {
        DontDestroyOnLoad(gameObject);
    }
    }
    
}
