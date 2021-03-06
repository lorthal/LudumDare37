using System;
using UnityEngine;


namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof(CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use

        public float multiplier { get; set; }

        bool isDischarged = false;

        [SerializeField]
        Animator cameraAnimator;

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
            if(!isDischarged || cameraAnimator.GetCurrentAnimatorStateInfo(0).IsName("IdleCam"))
            {
                float h = Input.GetAxis("Horizontal");
                float v = Input.GetAxis("Vertical") * multiplier;
                m_Car.Move(h, v, v, 0);
            }
            else
            {
                m_Car.Move(0, 0, 0, 0);
                foreach (var item in GetComponents<AudioSource>())
                {
                    item.Stop();
                }
            }
        }

        public void Discharge()
        {
            isDischarged = true;
        }
    }
}
