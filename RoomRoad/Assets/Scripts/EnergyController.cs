using UnityEngine;
using System.Collections;
using UnityStandardAssets;

public class EnergyController : MonoBehaviour {

    public float energyMaxAmount = 200f;
    float energyCurrentAmount;
    bool discharged = false;

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
        }

	}

    public void RechargeBattery()
    {
        energyCurrentAmount += 30.0f;
        if (energyCurrentAmount > energyMaxAmount)
            energyCurrentAmount = energyMaxAmount;
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
