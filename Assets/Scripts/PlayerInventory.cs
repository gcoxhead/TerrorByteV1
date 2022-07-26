using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfFloppys { get; private set;}

    public UnityEvent<PlayerInventory> OnFloppyCollected;
    
    public void FloppyDiskCollected()
    {
        NumberOfFloppys++;
        OnFloppyCollected.Invoke(this);
    }
}
