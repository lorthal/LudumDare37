using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControlls : MonoBehaviour {

    float gameTime;
    public Text timeText;

    bool gameIsStarted, canCount;

	// Use this for initialization
	void Start () {
        gameTime = 0.0f;
        gameIsStarted = false;
        canCount = true;
        timeText.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }

        if (Input.GetKey(KeyCode.R) && Camera.main.gameObject.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("IdleCam"))
        {
            timeText.gameObject.SetActive(true);
            gameIsStarted = true;
        }

        if (gameIsStarted == true && canCount == true)
        {
            gameTime += Time.deltaTime;

            timeText.text = gameTime.ToString("F2") + "s";
        }


    }

    public void DisableCount()
    {
        canCount = false;
    }
}
