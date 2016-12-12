using UnityEngine;
using System.Collections;

public class BookshelfAnimationTrigger : MonoBehaviour {

    enum ShelfState { Activated, Deactivated }
    ShelfState state;

    public GameObject obj;

    void Start()
    {
        state = ShelfState.Deactivated;
        obj.GetComponent<Animator>().Stop();
    }

    void OnTriggerEnter(Collider coll)
    {
        Debug.Log("S");
        if(coll.gameObject.tag == "Player" && state == ShelfState.Deactivated)
        {
            obj.GetComponent<Animation>().Play("Anim1");
            state = ShelfState.Activated;
        }
    }
}
