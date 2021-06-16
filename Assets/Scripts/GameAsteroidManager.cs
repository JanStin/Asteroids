using System.Collections;
using UnityEngine;
using UnityEngine.UI;
// TODO: Зарефакторить UI с нуля, если будет время и лучше идеи.
public class GameAsteroidManager : MonoBehaviour
{
    static public GameAsteroidManager gameAsteroidManager;

    [SerializeField] private Text scoreLabel;
    [SerializeField] private Text gameOverLabel;

    private int score;

    private void Awake()
    {
        if  (gameAsteroidManager == null)
        {
            gameAsteroidManager = this;
        }
        else
        {
            Debug.LogError("Error: gameAsteroidManager.Awake(): gameAsteroidManager is already set!");
        }
    }

    private void Start()
    {
        score = 0;
        gameOverLabel.gameObject.SetActive(false);
    }

    static public void ChangeScore()
    {
        gameAsteroidManager.score++;
        gameAsteroidManager.scoreLabel.text = "Score: " + gameAsteroidManager.score;
    }

    public void GameOver()
    {
        DestroyObjects();
        gameAsteroidManager.ShowGameOverLabel();
        StartCoroutine(ShowGameOverLabel());
    }

    private void DestroyObjects()
    {
        
        GameObject[] enemyObjects = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject obj in enemyObjects)
        {
            Destroy(obj);
        }
        GameObject[] projectileObjects = GameObject.FindGameObjectsWithTag("Projectile");
        foreach (GameObject obj in projectileObjects)
        {
            Destroy(obj);
        }
    }

    private IEnumerator ShowGameOverLabel()
    {
        gameAsteroidManager.gameOverLabel.text = "Game Over! Your score: " + gameAsteroidManager.score;
        gameAsteroidManager.gameOverLabel.gameObject.SetActive(true);
        gameAsteroidManager.score = 0;

        yield return new WaitForSeconds(1);

        gameAsteroidManager.gameOverLabel.gameObject.SetActive(false);
    }

}
