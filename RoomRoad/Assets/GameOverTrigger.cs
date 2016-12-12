using UnityEngine;
using System.Collections;

public class GameOverTrigger : MonoBehaviour {

    void OnTriggerEnter(Collider coll)
    {
        if(coll.gameObject.tag == "Player")
        {
            Debug.Log("Game Over!");
        }
    }
}
