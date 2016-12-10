using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    [SerializeField]
    private float accleration, rotationSpeed;

    private Rigidbody rb;
    private float horizontral, vertical;

	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	void Update () {

        horizontral = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        rb.AddForce(transform.forward * vertical * accleration);
        rb.transform.Rotate(Vector3.up, horizontral * rotationSpeed);
	}
}
