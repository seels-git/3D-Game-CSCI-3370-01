using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [Header("Game Over")]
    public GameObject gameOverPanel;

    [Header("Win Screen")]
    public GameObject winPanel;
    public TextMeshProUGUI winTimeText;

    [Header("Gameplay UI")]
    public TextMeshProUGUI timerText;

    float elapsedTime;
    bool timerRunning = true;

    void Awake() => Instance = this;

    void Update()
    {
        if (timerRunning)
        {
            elapsedTime += Time.deltaTime;
            int minutes = (int)(elapsedTime / 60);
            int seconds = (int)(elapsedTime % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }

    public void ShowGameOver()
    {
        timerRunning = false;
        gameOverPanel.SetActive(true);
    }

    public void ShowWin()
    {
        timerRunning = false;
        winPanel.SetActive(true);
        int minutes = (int)(elapsedTime / 60);
        int seconds = (int)(elapsedTime % 60);
        winTimeText.text = string.Format("Time: {0:00}:{1:00}", minutes, seconds);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}