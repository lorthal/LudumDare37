using System;
using UnityEngine;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof(CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use

        public float multiplier { get; set; }


        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }

        private void Start()
        {
            multiplier = 1;
        }

        private void FixedUpdate()
        {
            // pass the input to the car!
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical") * multiplier;
            m_Car.Move(h, v, v, 0);
        }
    }
}
