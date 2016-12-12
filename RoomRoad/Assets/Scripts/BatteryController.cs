using UnityEngine;
using System.Collections;

public class BatteryController : MonoBehaviour {

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            Recharge(collider.gameObject);
        }
    }

    void Recharge(GameObject player)
    {
        Debug.Log("Player is being recharged...");
        player.GetComponent<EnergyController>().RechargeBattery();

        Destroy(gameObject);
    }
}
