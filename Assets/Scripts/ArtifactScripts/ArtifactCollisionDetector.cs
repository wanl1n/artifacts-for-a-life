using System;
using TMPro;
using UnityEngine;

[Serializable]
public class ArtifactCollisionDetector : MonoBehaviour
{

    [SerializeField] private PlayerStatsManager playerStatsManager;

    private void Start()
    {
        playerStatsManager = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStatsManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            IncrementScore();
            Destroy(gameObject);
        }
    }

    private void IncrementScore()
    {
        playerStatsManager.IncrementScore();
    }
}
