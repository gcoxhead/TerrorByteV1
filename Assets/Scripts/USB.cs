using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class USB : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if (playerInventory != null)
        {
            playerInventory.USBCollected();
            gameObject.SetActive(false);
        }
    }
}
