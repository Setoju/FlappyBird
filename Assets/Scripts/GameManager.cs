using UnityEngine;
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

    public AudioSource gameOverSound;

    private void Awake()
    {
        Application.targetFrameRate = 144;

        personalBest = PlayerPrefs.GetInt("PersonalBest", 0);
        personalBestText.text = "Best: " + personalBest.ToString();

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

        Pipes[] pipes = FindObjectsByType<Pipes>(FindObjectsSortMode.None);

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
        gameOverSound.Play();
        gameOver.SetActive(true);
        playButton.SetActive(true);
        if (score > personalBest)
        {
            personalBest = score;
            SavePersonalBest();
            personalBestText.text = "Best: " + score.ToString();
        }

        Pause();
    }
    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    private void SavePersonalBest()
    {
        PlayerPrefs.SetInt("PersonalBest", personalBest);
        PlayerPrefs.Save();
    }
}
