using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnergyBarController : MonoBehaviour {

    public Image EnergyBarObj;
    public GameObject player;
    EnergyController energyController;
    float fillAmt;


	// Use this for initialization
	void Start () {
        energyController = player.GetComponent<EnergyController>();
	}
	
	// Update is called once per frame
	void Update () {
        if(energyController.GetEnergyAmount() >= 0)
        {
            fillAmt = (1 / energyController.energyMaxAmount) * energyController.GetEnergyAmount();
            EnergyBarObj.fillAmount= fillAmt;
        }

	}
}
