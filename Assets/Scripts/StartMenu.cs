using UnityEngine;
using UnityEngine.SceneManagement;


/// <summary>
/// Class <c>StartMenu</c> using UI elements and show panels in a specified order
/// </summary>
public class StartMenu : MonoBehaviour
{
    /// <param name="tutorialPanel"> UI element oppening panel one </param>
    public GameObject tutorialPanel;

    /// <param name="tutorialPanel2"> UI element oppening panel two </param>
    public GameObject tutorialPanel2;

    /// <param name="tutorialPanel3"> UI element oppening panel three  </param>
    public GameObject tutorialPanel3;

    /// <param name="tutorialPanel4"> UI element oppening panel four </param>
    public GameObject tutorialPanel4;

    private void Start()
    {
        tutorialPanel.SetActive(false);
        tutorialPanel2.SetActive(false);
        tutorialPanel3.SetActive(false);
        tutorialPanel4.SetActive(false);
    }
    public void GameStart()
    {
        SceneManager.LoadScene("Skole");
    }

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

    public void HidePanel()
    {
        tutorialPanel.SetActive(false);
        tutorialPanel2.SetActive(false);
        tutorialPanel3.SetActive(false);
        tutorialPanel4.SetActive(false);
    }

    public void reloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
