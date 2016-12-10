using UnityEngine;
using System.Collections;

public class EnergyController : MonoBehaviour {

    float energyMaxAmount = 100.0f;
    float energyCurrentAmount;

	// Use this for initialization
	void Start () {
        energyCurrentAmount = energyMaxAmount;
	}
	
	// Update is called once per frame
	void Update () {
        energyCurrentAmount -= Time.deltaTime;
        if (energyCurrentAmount <= 0)
            Debug.Log("Rozladowany XD");

        Debug.Log(energyCurrentAmount);
	}

    public void RechargeBattery()
    {
        energyCurrentAmount = energyMaxAmount;
    }

    public float GetEnergyAmount()
    {
        return energyCurrentAmount;
    }
}
