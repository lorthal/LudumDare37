using UnityEngine;
using System.Collections;

public class EnergyController : MonoBehaviour {

    public float energyMaxAmount = 15f;
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
            discharged = true;
	}

    public void RechargeBattery()
    {
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
