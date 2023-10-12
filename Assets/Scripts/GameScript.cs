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

    public void winner()
    {
        _winnerScreen.SetActive(true);
        winnerText.SetText("YOU GATHERED " + playerStatsManager.artifactsCollected + " ARTIFACTS AND INCREASED \nTHE REVENUE OF YOUR MUSEUM!!!");
    }

    public void gameOver()
    {
        _winnerScreen.SetActive(true);
        winnerText.SetText("OH NO! YOU ARE TRAPPED! YOUR " + playerStatsManager.artifactsCollected + " COLLECTED ARTIFACTS ARE WASTED!");
    }

    public void restartGame()
    {
        Debug.Log("Restart");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
