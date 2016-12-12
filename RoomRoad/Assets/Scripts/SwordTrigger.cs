using UnityEngine;
using System.Collections;

public class SwordTrigger : MonoBehaviour {
    

    void Start()
    {
    }

    void OnTriggerEnter(Collider coll)
    {
        if(coll.gameObject.tag == "Player")
        {
            GetComponentInParent<Animator>().SetTrigger("SwordTrigger");
        }
    }
}
