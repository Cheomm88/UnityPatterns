using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupVida : MonoBehaviour, IPickablePowerup
{

    public void PickupPowerup()
    {
        Debug.Log("Recoger vida");
    }

}
