using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI floppyText;
    private TextMeshProUGUI USBText;
    // Start is called before the first frame update

    void Start()
    {
        floppyText = GetComponent<TextMeshProUGUI>();
        USBText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateFloppyText(PlayerInventory playerInventory)
    {
        floppyText.text = playerInventory.NumberOfFloppys.ToString();
    }

     public void UpdateUSB(PlayerInventory playerInventory)
    {
        USBText.text = playerInventory.NumberOfUSBs.ToString();
    }
}
