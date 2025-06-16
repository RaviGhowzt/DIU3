using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    [SerializeField] GameObject gameOverPanel;

    [SerializeField] Button restartButton;

    private bool GameRunning;

    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        restartButton.onClick.AddListener(RestartGame);
    }

    void RestartGame()
    {
        SceneManager.LoadScene(1);
    }

    public bool IsGameRunning()
    {
        return GameRunning;
    }

    public void GameOver()
    {
        GameRunning = false;
        gameOverPanel.SetActive(true);
    }
}
