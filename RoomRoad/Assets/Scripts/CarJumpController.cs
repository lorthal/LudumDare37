using UnityEngine;
using System.Collections;

public class CarJumpController : MonoBehaviour {
    
    public float jumpValue = 10;
    float jumpCooldown = 2.0f;
    public GameObject[] tires;

    enum JumpState { isJumping, Idle}
    JumpState currentState;
    private bool isGrounded;

    // Use this for initialization
    void Start () {
        currentState = JumpState.Idle;
        isGrounded = true;
        StartCoroutine(Jump());
        
	}

    void Update()
    {
        Debug.Log(isGrounded.ToString());
    }

    //make sure u replace "floor" with your gameobject name.on which player is standing
    void OnTriggerStay(Collider coll)
    {
        if (coll.gameObject.tag == "floor")
        {
            foreach (var i in tires)
            {
                if (i.GetComponent<WheelJumpTrigger>().GetCollided() == false)
                    break;

                isGrounded = true;
            }
            
        }
    }

    //consider when character is jumping .. it will exit collision.
    void OnTriggerExit(Collider coll)
    {
        if (coll.gameObject.tag == "floor")
        {
            isGrounded = false;
        }
    }

    IEnumerator Jump()
    {

        while (true)
        {
            
            if (Input.GetButtonDown("Jump") && isGrounded == true && currentState == JumpState.Idle)
            {
                gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
                currentState = JumpState.isJumping;
                gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, jumpValue, 0), ForceMode.VelocityChange);
                yield return new WaitForSeconds(jumpCooldown);
                currentState = JumpState.Idle;
            }

            yield return null;
        }
    }
}



