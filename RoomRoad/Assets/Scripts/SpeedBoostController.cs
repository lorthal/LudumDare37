using UnityEngine;
using System.Collections;

public class SpeedBoostController : MonoBehaviour
{
    public enum BoosterState
    {
        Enabled,
        Enabling,
        Disabled,
        Disabling
    }
    [SerializeField]
    bool boosterEnabled = true;
    public BoosterState state { get; set; }
    public float boostSpeed = 10.0f;
    private float tempBoostSpeed;
    public GameObject startTrigger;
    public GameObject endTrigger;

    [SerializeField]
    ParticleSystem[] borderParticle;
    [SerializeField]
    ParticleSystem boostParticle;

    void Start()
    {
        if(boosterEnabled)
        {
            state = BoosterState.Enabling;
        }
        else
        {
            state = BoosterState.Disabling;
        }
    }

    void Update()
    {
        if (state == BoosterState.Disabling)
        {
            foreach (var item in borderParticle)
            {
                item.startColor = Color.grey;
            }
            boostParticle.Stop();
            state = BoosterState.Disabled;
        }
        if (state == BoosterState.Disabled)
        {
            tempBoostSpeed = 0;
        }
        if (state == BoosterState.Enabling)
        {
            foreach (var item in borderParticle)
            {
                item.startColor = Color.blue;
            }
            boostParticle.Play();
            state = BoosterState.Enabled;
        }
        if (state == BoosterState.Enabled)
        {
            tempBoostSpeed = boostSpeed;
        }
    }

    void OnTriggerEnter(Collider collider)
    {

        if (startTrigger.GetComponent<BoostTriggerController>().IsActive())
            if (collider.gameObject.tag == "Player")
            {
                BoostSpeed(collider.gameObject);
            }
    }

    void BoostSpeed(GameObject player)
    {
        player.GetComponent<Rigidbody>().AddForce(player.gameObject.transform.forward * tempBoostSpeed, ForceMode.Acceleration);
    }
}
