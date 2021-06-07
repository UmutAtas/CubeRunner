using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gManager;
    private void OnTriggerEnter()
    {
        gManager.CompleteLevel();
    }
}
