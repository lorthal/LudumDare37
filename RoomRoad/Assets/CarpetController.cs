using UnityEngine;
using System.Collections;
using UnityStandardAssets.Vehicles.Car;


public class CarpetController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerStay(Collider collider)
    {
       if(collider.tag == "Player")
        {
            //collider.GetComponent<CarUserControl>().multiplier = 0.2f;
            var wheels = collider.gameObject.GetComponent<CarController>().WheelColliders;
            foreach (var item in wheels)
            {
                WheelFrictionCurve sFriction = item.sidewaysFriction;
                WheelFrictionCurve fFriction = item.forwardFriction;
                sFriction.stiffness = 0.3f;
                fFriction.stiffness = 0.3f;
                item.sidewaysFriction = sFriction;
                item.forwardFriction = fFriction;
            }
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.tag == "Player")
        {
            var wheels = collider.gameObject.GetComponent<CarController>().WheelColliders;
            foreach (var item in wheels)
            {
                WheelFrictionCurve sFriction = item.sidewaysFriction;
                WheelFrictionCurve fFriction = item.forwardFriction;
                sFriction.stiffness = 1.0f;
                fFriction.stiffness = 1.0f;
                item.sidewaysFriction = sFriction;
                item.forwardFriction = fFriction;
            }
        }
    }
}
