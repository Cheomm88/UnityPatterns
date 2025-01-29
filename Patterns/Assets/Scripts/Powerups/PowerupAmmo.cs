using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupAmmo : MonoBehaviour, IPickablePowerup
{

    public void PickupPowerup()
    {
        Debug.Log("Recoger ammo");
    }

}
