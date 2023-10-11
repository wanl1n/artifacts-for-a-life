using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Enter()
    {
        SceneManager.LoadScene(1);
    }

    public void Leave()
    {
        Application.Quit();
    }

    public void Pause()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0.0f;
        Player.GetComponent<BasicBehaviour>().enabled = false;
        Player.GetComponent<MoveBehaviour>().enabled = false;
        Player.GetComponent<AimBehaviourBasic>().enabled = false;
        Player.GetComponentInChildren<ThirdPersonOrbitCamBasic>().enabled = false;
    }

    public void Resume()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1.0f;
        Player.GetComponent<BasicBehaviour>().enabled = true;
        Player.GetComponent<MoveBehaviour>().enabled = true;
        Player.GetComponent<AimBehaviourBasic>().enabled = true;
        Player.GetComponentInChildren<ThirdPersonOrbitCamBasic>().enabled = true;
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
