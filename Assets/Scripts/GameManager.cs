using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool isGameActive;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI startGameText;
    public Button restartButton;
    public GameObject basket;
    private MoveBasket basketScript;
    public bool hasRun;
    // Start is called before the first frame update
    void Start()
    {
        basketScript = basket.GetComponent<MoveBasket>();
        hasRun = false;
        startGameText.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(hasRun == false && Input.anyKeyDown)
        {
            startGameText.gameObject.SetActive(false);
            StartGame();
            isGameActive = true;
            hasRun = true;
        }
    }

    public void StartGame()
    {
        basketScript.speed = 5.0f;
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        isGameActive = false;
        basketScript.speed = 0.0f;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
