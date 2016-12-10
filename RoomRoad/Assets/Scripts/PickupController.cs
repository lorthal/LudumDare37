using UnityEngine;
using System.Collections;

public class PickupController : MonoBehaviour {

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            PickUp(collider.GetComponent<PlayerController>());
        }
    }

    void PickUp(PlayerController player)
    {
        Debug.Log("Picked up!");
    }
}
