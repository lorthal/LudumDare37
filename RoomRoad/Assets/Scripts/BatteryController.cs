using UnityEngine;
using System.Collections;

public class BatteryController : MonoBehaviour {

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            Recharge(collider.GetComponent<PlayerController>());
        }
    }

    void Recharge(PlayerController player)
    {
        Debug.Log("Player is being recharged...");
    }
}
