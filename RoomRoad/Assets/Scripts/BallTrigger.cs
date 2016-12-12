using UnityEngine;
using System.Collections;

public class BallTrigger : MonoBehaviour {

    [SerializeField]
    float force = 5000;

	void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "Player")
        {
            Debug.Log("Ball");
            collider.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            collider.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(-0.25f, 1, 0.125f).normalized * force);
        }
    }
}
