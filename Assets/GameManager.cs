using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject GameOverScreen;
    [SerializeField] private TMP_Text ScoreText;

    private int score;

    public static GameManager Instance { get; private set; }


    public void ShowGameOverScreen()
    {
        GameOverScreen.SetActive(true);
    }


    public void RestartScene()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
      Time.timeScale = 1f;
    }

}
