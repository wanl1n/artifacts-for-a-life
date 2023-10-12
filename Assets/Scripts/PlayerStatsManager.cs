using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerStatsManager : MonoBehaviour
{
    public float artifactsCollected = 0;
    public float toolsCollected = 0;

    public TMP_Text artifactCounter;
    public TMP_Text toolCounter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        artifactCounter.text = artifactsCollected.ToString();
        toolCounter.text = toolsCollected.ToString();  
    }
}
