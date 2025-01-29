using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpPowerupAblity : MonoBehaviour
{

    void OnTriggerEnter(Collider coll)
    {
        Debug.Log("Triger enter");
       
        if (coll.gameObject.TryGetComponent(out IPickablePowerup powerupCogido))
        {
            powerupCogido.PickupPowerup();
        }
    }


}
