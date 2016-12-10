using UnityEngine;
using System.Collections;

public class CarJumpController : MonoBehaviour {
    
    public float jumpValue = 100;
    float jumpCooldown = 2.0f;

    enum JumpState { isJumping, Idle}
    JumpState currentState;
    private bool isGrounded;

    // Use this for initialization
    void Start () {
        currentState = JumpState.Idle;
        StartCoroutine(Jump());
	}

    //make sure u replace "floor" with your gameobject name.on which player is standing
    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.name == "floor")
        {
            isGrounded = true;
        }
    }

    //consider when character is jumping .. it will exit collision.
    void OnTriggerExit(Collider coll)
    {
        if (coll.gameObject.name == "floor")
        {
            isGrounded = false;
        }
    }

    IEnumerator Jump()
    {

        while (true)
        {
            
            if (Input.GetButtonDown("Jump") && isGrounded == false)
            {
                currentState = JumpState.isJumping;
                gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, jumpValue, 0), ForceMode.VelocityChange);
                yield return new WaitForSeconds(jumpCooldown);
                currentState = JumpState.Idle;
            }

            yield return null;
        }
    }
}



