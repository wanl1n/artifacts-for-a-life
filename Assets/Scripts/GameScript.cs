using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour
{

    [SerializeField] private GameObject _winnerScreen;
    [SerializeField] private TMP_Text winnerText;

    [SerializeField] private PlayerStatsManager playerStatsManager;

    [SerializeField] private bool gameFinished = false;

    public void Winner()
    {
        _winnerScreen.SetActive(true);
        winnerText.SetText("YOU GATHERED " + playerStatsManager.artifactsCollected + " ARTIFACTS AND INCREASED \nTHE REVENUE OF YOUR MUSEUM!!!");
    }

    public void GameOver()
    {
        _winnerScreen.SetActive(true);
        winnerText.SetText("OH NO! YOU ARE TRAPPED! YOUR " + playerStatsManager.artifactsCollected + " COLLECTED ARTIFACTS ARE WASTED!");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public bool GetGameFinished()
    {
        return gameFinished;
    }

    public void SetGameFinished(bool gameFinished)
    {
        this.gameFinished = gameFinished;
    }
}
