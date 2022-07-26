using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI floppyText;
    // Start is called before the first frame update

    void Start()
    {
        floppyText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateFloppyText(PlayerInventory playerInventory)
    {
        floppyText.text = playerInventory.NumberOfFloppys.ToString();
    }
}
