using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int scoreInt = 0;
    public Text score;

    public void UpdateScore()
    {
        scoreInt++;
        score.text = scoreInt.ToString();
    }
}
