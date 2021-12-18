using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSetup : MonoBehaviour
{
    public GameObject cameraHolder;
    
    public void IsLocalPlayer()
    {
        cameraHolder.SetActive(true);
        GetComponent<Movement>().enabled = true;
    }
}
