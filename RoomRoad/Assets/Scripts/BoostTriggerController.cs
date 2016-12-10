using UnityEngine;
using System.Collections;

public class BoostTriggerController : MonoBehaviour {
    bool isActive;
    GameObject player;

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            isActive = true;
            player = collider.gameObject;
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            isActive = false;
            player = null;
        }
    }

    public bool IsActive()
    {
        return isActive;
    }
    public GameObject GetPlayer()
    {
        return player;
    }
}
