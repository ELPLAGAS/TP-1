using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class Score : MonoBehaviour
{
    int contador;
    public int totalItems;


    [SerializeField] public TMP_Text score;
    [SerializeField] public TMP_Text win;




    public void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        contador = contador + 1;
        updateScore();

        if (contador == totalItems)
        {
            win.gameObject.SetActive(true);
        }
    }

    private void updateScore()
    {
        score.text = contador.ToString() + " / " + totalItems.ToString();
    }

    public void Awake()
    {
        totalItems = GameObject.FindGameObjectsWithTag("Item").Length;

        contador = 0;
        updateScore();
        win.gameObject.SetActive(false);

    }


    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

}