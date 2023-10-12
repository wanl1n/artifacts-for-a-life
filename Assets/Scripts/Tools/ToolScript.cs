using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.UIElements;

public class ToolScript : MonoBehaviour
{
    [SerializeField] private GameObject _toolPanel;
    [SerializeField] private Light _playerLantern;
    [SerializeField] private int _lightIncrement;

    [SerializeField] private GameObject _GameManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
            _toolPanel.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
            _toolPanel.SetActive(false);
    }

    public void use()
    {
        if (this.gameObject.tag == "Lantern")
        {
            Destroy(this.gameObject);
            _playerLantern.range += _lightIncrement;
            _toolPanel.SetActive(false);
        }

        if (this.gameObject.tag == "Ladder")
        {
            _GameManager.GetComponent<GameScript>().winner();
            _toolPanel.SetActive(false);
        }
    }
}