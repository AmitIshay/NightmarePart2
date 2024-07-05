using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    //[SerializeField] int ammoAmount = 10;
    [SerializeField] ammoSlot[] ammoSlots;

    [System.Serializable] 
    private class ammoSlot
    {
        public AmmoType ammoType;
        public int ammoAmount;
    }

    public int GetCurrentAmmo(AmmoType ammoType)
    {
        return GetAmmoSlot(ammoType).ammoAmount;
    }

    public void ReduceCurrentAmmo(AmmoType ammoType)
    {
        GetAmmoSlot(ammoType).ammoAmount--;
    }
    public void IncreaseCurrentAmmo(AmmoType ammoType, int ammoAmount)
    {
        GetAmmoSlot(ammoType).ammoAmount += ammoAmount;
    }
    private ammoSlot GetAmmoSlot(AmmoType ammoType)
    {
        foreach(ammoSlot slot in ammoSlots)
        {
            if (slot.ammoType == ammoType) return slot;
        }
        return null;
    } 
}
