using UnityEngine;
using TMPro;

public class ScoreBoard : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreUi;
    private int score;

    public void AddScore(int amount)
    {
        score = score + amount;
        scoreUi.text = score.ToString();
        Debug.Log("Your Score : " + score);
    }
}
