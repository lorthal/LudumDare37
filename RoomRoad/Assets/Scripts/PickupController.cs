using UnityEngine;
using System.Collections;

public class PickupController : MonoBehaviour {

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            PickUp(collider.gameObject);
        }
    }

    void PickUp(GameObject player)
    {
        Debug.Log("Picked up!");
    }
}
