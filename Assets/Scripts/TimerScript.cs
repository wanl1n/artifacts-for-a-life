using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class TimerScript : MonoBehaviour
{
    [SerializeField] TMP_Text m_Text;
    [SerializeField] float time;

    private GameScript _gameScript;


    void Start()
    {
        _gameScript = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameScript>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0 && !_gameScript.GetGameFinished())
        {
            time -= Time.deltaTime;
        }
        else if (time < 0)
        {
            time = 0;
            _gameScript.GameOver();
        }

        int mins = Mathf.FloorToInt(time / 60);
        int secs = Mathf.FloorToInt(time % 60);
        m_Text.text = "Timer: " + string.Format("{0:00}:{1:00}", mins, secs);
    }
}
