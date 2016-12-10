using UnityEngine;
using System.Collections;

public class SpeedBoostController : MonoBehaviour {

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            BoostSpeed(collider.gameObject);
        }
    }

    void BoostSpeed(GameObject player)
    {
        Debug.Log("Player boost...");
    }
}
