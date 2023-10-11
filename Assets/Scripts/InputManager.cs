using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseMenu.SetActive(true);
            Player.GetComponent<BasicBehaviour>().enabled = false;
            Player.GetComponent<MoveBehaviour>().enabled = false;
            Player.GetComponent<AimBehaviourBasic>().enabled = false;
            Player.GetComponentInChildren<ThirdPersonOrbitCamBasic>().enabled = false;
        }
    }
}
