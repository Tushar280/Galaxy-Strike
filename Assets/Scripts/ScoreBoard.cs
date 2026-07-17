using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    private int score;

    public void AddScore(int amount)
    {
        score = score + amount;
        Debug.Log("Your Score : " + score);
    }
}
