using UnityEngine;
using System.Collections;

public class SpeedBoostController : MonoBehaviour {

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            BoostSpeed(collider.GetComponent<PlayerController>());
        }
    }

    void BoostSpeed(PlayerController player)
    {
        Debug.Log("Player boost...");
    }
}
