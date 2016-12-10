using UnityEngine;
using System.Collections;

public class SpeedBoostController : MonoBehaviour
{

    public float boostSpeed = 10.0f;
    public GameObject startTrigger;
    public GameObject endTrigger;

    void OnTriggerEnter(Collider collider)
    {
        if (startTrigger.GetComponent<BoostTriggerController>().IsActive())
            if (collider.gameObject.tag == "Player")
            {
                BoostSpeed(collider.gameObject);
            }
    }

    void BoostSpeed(GameObject player)
    {
        player.GetComponent<Rigidbody>().AddForce(player.gameObject.transform.forward * boostSpeed, ForceMode.Acceleration);
    }
}
