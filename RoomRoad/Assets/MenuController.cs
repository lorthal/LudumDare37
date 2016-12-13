using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {

    public void StartButton()
    {
        SceneManager.LoadScene("levelDesign");
    }
    public void EndButton()
    {
        Application.Quit();
    }
    public void AboutButton()
    {
        SceneManager.LoadScene("MainMenu 1");
    }
    public void BackButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
