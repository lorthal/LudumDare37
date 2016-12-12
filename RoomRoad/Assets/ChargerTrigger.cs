using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChargerTrigger : MonoBehaviour {

    public Text gameResultText;

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            gameResultText.gameObject.SetActive(true);
            gameResultText.text = "You Won!";
        }
    }
}
