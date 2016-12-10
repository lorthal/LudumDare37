using UnityEngine;
using System.Collections;
using System;

public class FlipCar : MonoBehaviour {

    //[SerializeField]
    //private float timeToFlip;

    //private float currentTime;

    private Rigidbody rb;

	void Start () {
        //currentTime = 0.0f;
        rb = GetComponent<Rigidbody>();
        StartCoroutine(Flip());
	}

	void Update () {
        
	}

    IEnumerator Flip()
    {
        while (true)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                rb.velocity = Vector3.zero;
                Vector3 targetPos = new Vector3(rb.transform.position.x, rb.transform.position.y + 1, rb.transform.position.z);
                rb.transform.position = targetPos;
                Vector3 targetRot = new Vector3(0, transform.eulerAngles.y, 0);
                rb.transform.rotation = Quaternion.Euler(targetRot);
                yield return new WaitForSeconds(1.0f);
            }
            yield return null;
        }
        
    }
}
