using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {

    public Button startButton;
    public Button endButton;
    public Button aboutButton;
	// Use this for initialization
	void Start () {
        startButton.onClick.AddListener(StartButton);
        endButton.onClick.AddListener(EndButton);
        aboutButton.onClick.AddListener(AboutButton);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
    void StartButton()
    {
        SceneManager.LoadScene("levelDesign");
    }
    void EndButton()
    {
        Application.Quit();
    }
    void AboutButton()
    {

    }
}
