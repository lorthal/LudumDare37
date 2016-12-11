using UnityEngine;
using System.Collections;

public class WheelJumpTrigger : MonoBehaviour {

    bool isCollided;

	// Use this for initialization
	void Start () {
        isCollided = true;
	}

    void OnTriggerStay(Collider coll)
    {
        if (coll.gameObject.tag == "floor")
            isCollided = true;
    }
    void OnTriggerExit(Collider coll)
    {
        if (coll.gameObject.tag == "floor")
            isCollided = false;
    }

    // Update is called once per frame
    void Update () {
	
	}

    public bool GetCollided()
    {
        return isCollided;
    }
}
