using UnityEngine;
using System.Collections;

public class CarJumpController : MonoBehaviour {

    public GameObject car;
    public float jumpValue = 100;
    float jumpCooldown = 2.0f;

    enum JumpState { isJumping, Idle}
    JumpState currentState;

	// Use this for initialization
	void Start () {
        currentState = JumpState.Idle;
        StartCoroutine(Jump());
	}
	
	// Update is called once per frame
	void Update () {
	}
    IEnumerator Jump()
    {

        while (true)
        {
            if (Input.GetButtonDown("Jump"))
            {
                currentState = JumpState.isJumping;
                car.GetComponent<Rigidbody>().AddForce(new Vector3(0, jumpValue, 0), ForceMode.VelocityChange);
                yield return new WaitForSeconds(jumpCooldown);
                currentState = JumpState.Idle;
            }

            yield return null;
        }
    }
}



