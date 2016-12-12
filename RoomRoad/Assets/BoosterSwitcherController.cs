using UnityEngine;
using System.Collections;

public class BoosterSwitcherController : MonoBehaviour {

    [SerializeField]
    SpeedBoostController booster;
    [SerializeField]
    float time = 30.0f;

    void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "Player" && booster.state == SpeedBoostController.BoosterState.Disabled)
        {
            booster.state = SpeedBoostController.BoosterState.Enabling;
            GetComponentInChildren<ParticleSystem>().startColor = Color.gray;
            var cos = GetComponentInChildren<ParticleSystem>().emission;
            cos.rate = 10;
            StartCoroutine(SwitchCooldown());
        }
    }

    IEnumerator SwitchCooldown()
    {
        while (true)
        {
            if(booster.state == SpeedBoostController.BoosterState.Enabled)
            {
                yield return new WaitForSeconds(time);
                Debug.Log("timesUp");
                booster.state = SpeedBoostController.BoosterState.Disabling;
                GetComponentInChildren<ParticleSystem>().startColor = Color.green;
                var cos = GetComponentInChildren<ParticleSystem>().emission;
                cos.rate = 500;
                StopCoroutine(SwitchCooldown());
            }
            yield return null;
        }
    }
}
