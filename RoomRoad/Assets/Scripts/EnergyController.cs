using UnityEngine;
using System.Collections;
using UnityStandardAssets;

public class EnergyController : MonoBehaviour {

    public float energyMaxAmount = 200f;
    float energyCurrentAmount;
    bool discharged = false;
    [SerializeField]
    Animator particleAnimator;
    [SerializeField] ParticleSystem particle;

    bool particlePlay = false;

	// Use this for initialization
	void Start () {
        energyCurrentAmount = energyMaxAmount;
	}
	
	// Update is called once per frame
	void Update () {
        energyCurrentAmount -= Time.deltaTime;
        if (energyCurrentAmount <= 0)
        {
            discharged = true;
            GetComponent<UnityStandardAssets.Vehicles.Car.CarUserControl>().Discharge();
            if (!particlePlay)
            {
                particleAnimator.SetTrigger("Discharged");
                particle.Play();
                particlePlay = true;
            }
            else if (particleAnimator.GetCurrentAnimatorStateInfo(0).IsName("New State 0"))
            {   
                particle.Stop();
                particleAnimator.Stop();  
            }
        }

	}

    public void RechargeBattery()
    {
        energyCurrentAmount += 40.0f;
    }

    public float GetEnergyAmount()
    {
        return energyCurrentAmount;
    }
    public bool IsDischarged()
    {
        return discharged;
    }
}
