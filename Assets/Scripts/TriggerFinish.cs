using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerFinish : MonoBehaviour
{
    public CheckpointCounter checkpointTracker;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if(checkpointTracker.triggeredCheckpoints == checkpointTracker.numberOfCheckpoints)
            {
                Debug.Log("You Win!");
                SceneManager.LoadScene(1);
            }
            else
            {
                Debug.Log("Cheater");
            }
        }
    }
}