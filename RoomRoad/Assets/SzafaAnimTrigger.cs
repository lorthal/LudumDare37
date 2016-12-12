using UnityEngine;
using System.Collections;

public class SzafaAnimTrigger : MonoBehaviour {

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            GetComponentInParent<Animator>().SetTrigger("OpenTrigger");
        }
    }
}
