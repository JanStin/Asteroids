using UnityEngine;
using UnityEngine.UI;

public class GameAsteroidManager : MonoBehaviour
{
    [SerializeField] private Text scoreLabel;
    [SerializeField] private Text gameOverLabel;

    private int score;
    public int Score
    {
        get
        {
            return score;
        }
        set
        {
            score = value;
            scoreLabel.text = "Score: " + score;
        }
    }

    private void Start()
    {
        Score = 0;
        gameOverLabel.gameObject.SetActive(false);
    }

}
