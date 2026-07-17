using UnityEngine;
using TMPro;

public class ScoreBoard : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreUi;
    private int score;

    public void AddScore(int amount)
    {
        score = score + amount;
        Debug.Log("Your Score : " + score);
    }
}
