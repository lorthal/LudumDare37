using UnityEngine;
using System.Collections;

public class LampAnimTrigger : MonoBehaviour {

	void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "Player")
        {
            GetComponentInParent<Animator>().SetTrigger("StartAnim");
        }
    }
}
