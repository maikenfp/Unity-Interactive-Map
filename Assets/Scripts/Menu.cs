using UnityEngine;
using UnityEngine.SceneManagement;


/// <summary>
/// Class <c>Menu</c> using UI elements and show panels in a specified order
/// </summary>
public class Menu : MonoBehaviour
{
    /// <param name="tutorialPanel"> UI element oppening panel one </param>
    public GameObject tutorialPanel;

    /// <param name="tutorialPanel2"> UI element oppening panel two </param>
    public GameObject tutorialPanel2;

    /// <param name="tutorialPanel3"> UI element oppening panel three  </param>
    public GameObject tutorialPanel3;

    /// <param name="tutorialPanel4"> UI element oppening panel four </param>
    public GameObject tutorialPanel4;

    //Hides all panels on start
    private void Start()
    {
        tutorialPanel.SetActive(false);
        tutorialPanel2.SetActive(false);
        tutorialPanel3.SetActive(false);
        tutorialPanel4.SetActive(false);
    }

    //Loads the game 
    public void GameStart()
    {
        SceneManager.LoadScene("Skole");
    }

    //Show specific tutorial panel
    public void ShowPanel1()
    {
        tutorialPanel.SetActive(true);

        tutorialPanel2.SetActive(false);
        tutorialPanel3.SetActive(false);
        tutorialPanel4.SetActive(false);
    }

    public void ShowPanel2()
    {
        tutorialPanel2.SetActive(true);

        tutorialPanel.SetActive(false);
        tutorialPanel3.SetActive(false);
        tutorialPanel4.SetActive(false);
    }

    public void ShowPanel3()
    {
        tutorialPanel3.SetActive(true);

        tutorialPanel.SetActive(false);
        tutorialPanel2.SetActive(false);
        tutorialPanel4.SetActive(false);
    }

    public void ShowPanel4()
    {
        tutorialPanel4.SetActive(true);

        tutorialPanel.SetActive(false);
        tutorialPanel2.SetActive(false);
        tutorialPanel3.SetActive(false);
    }

    //Hides all panels
    public void HidePanel()
    {
        tutorialPanel.SetActive(false);
        tutorialPanel2.SetActive(false);
        tutorialPanel3.SetActive(false);
        tutorialPanel4.SetActive(false);
    }

    //Reloads current scene
    public void reloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
