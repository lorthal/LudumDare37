using UnityEngine;
using System.Collections;

public class BookshelfAnimationTrigger : MonoBehaviour {

    enum ShelfState { Activated, Deactivated }

    public GameObject obj;

    void Start()
    {
        obj.GetComponent<Animator>().Stop();
    }

    void OnTriggerEnter(Collider coll)
    {
        Debug.Log("S");
        if(coll.gameObject.tag == "Player")
        {
            obj.GetComponent<Animation>().Play("Anim1");
        }
    }
}
