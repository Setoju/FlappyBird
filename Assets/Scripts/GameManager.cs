using UnityEngine;
using UnityEngine.LowLevel;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public Text personalBestText;
    public GameObject playButton;
    public GameObject gameOver;
    public Player player;
    private int score;
    private int personalBest;

    private void Awake()
    {
        Application.targetFrameRate = 144;
        Pause();
    }

    public void Play()
    {
        score = 0;
        scoreText.text = score.ToString();

        playButton.SetActive(false);
        gameOver.SetActive(false);
        Time.timeScale = 1f;
        player.enabled = true;

        Pipes[] pipes = FindObjectsOfType<Pipes>();

        for(int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }
    }
    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }
    public void GameOver()
    {
        gameOver.SetActive(true);
        playButton.SetActive(true);
        if (score > personalBest)
        {
            personalBest = score;
            personalBestText.text = "Best: " + score.ToString();
        }

        Pause();
    }
    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
