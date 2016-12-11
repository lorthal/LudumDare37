using UnityEngine;
using System.Collections;

public class FollowTransform : MonoBehaviour {
    [SerializeField]
    Transform target;
    [SerializeField]
    float rotationSpeed;
    Vector3 offset;

    void Awake()
    {
        offset = transform.position - target.position;
    }

	void Update () {
        transform.position = target.position + offset;


        //transform.rotation = Quaternion.Euler(Vector3.Lerp(transform.rotation.eulerAngles, new Vector3(0, Mathf.Abs(target.rotation.eulerAngles.y),0), Time.deltaTime * rotationSpeed)));
        transform.rotation = Quaternion.Lerp(transform.rotation, target.rotation, Time.deltaTime * rotationSpeed);
	}
}
