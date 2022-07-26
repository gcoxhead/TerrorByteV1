using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FloppyDisk : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if (playerInventory != null)
        {
            playerInventory.FloppyDiskCollected();
            gameObject.SetActive(false);
        }
    }
}
