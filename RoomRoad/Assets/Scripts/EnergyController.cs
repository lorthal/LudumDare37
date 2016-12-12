using UnityEngine;
using System.Collections;
using UnityStandardAssets;
using UnityEngine.UI;

public class EnergyController : MonoBehaviour {

    public float energyMaxAmount = 200f;
    float energyCurrentAmount;
    bool discharged = false;
    [SerializeField]
    Animator particleAnimator;
    [SerializeField] ParticleSystem particle;

    public Text gameResultText;

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
            gameResultText.gameObject.SetActive(true);
            gameResultText.text = "You Lost!";
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
