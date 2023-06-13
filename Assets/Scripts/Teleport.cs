using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// Class <c>Teleport</c> UI controller for telleporting to a room
/// </summary>
public class Teleport : MonoBehaviour
{
    /// <param name="position"> ScriptableObject of the player position </param>
    public VectorValue position;

    /// <param name="makerspaceBtn"> prefab of UI element </param>
    public GameObject makerspaceBtn;

    /// <param name="fablabBtn"> prefab of UI element</param>
    public GameObject fablabBtn;

    /// <param name="robotBtn"> prefab of UI element</param>
    public GameObject robotBtn;

    /// <param name="vrBtn"> prefab of UI element</param>
    public GameObject vrBtn;

    /// <param name="podkastBtn"> prefab of UI element</param>
    public GameObject podkastBtn;

    // Start is called before the first frame update
    // Each room listed is a button action. When button is clicked, said room is loaded and places character in chosen position.
    void Start()
    {
        //MAKERSPACE
        makerspaceBtn.GetComponent<Button>().onClick.AddListener(() =>
        {
            position.initialValue = new Vector3(-1.19f, 0.72f, -7.62f);
            SceneManager.LoadScene("MakerSpace");
        });

        //FAB LAB
        fablabBtn.GetComponent<Button>().onClick.AddListener(() =>
        {
            position.initialValue = new Vector3(-3.96f, 0.01f, -6.1f);
            SceneManager.LoadScene("FabLab");
        });

        //ROBOT LAB
        robotBtn.GetComponent<Button>().onClick.AddListener(() =>
        {
            position.initialValue = new Vector3(-0.74f, 1.3f, -9.54f);
            SceneManager.LoadScene("RobotLab");
        });

        //VR LAB
        vrBtn.GetComponent<Button>().onClick.AddListener(() =>
        {
            position.initialValue = new Vector3(-3.12f, 0.01f, -4.21f);
            SceneManager.LoadScene("VR_Room");
        });

        //PODKAST
        podkastBtn.GetComponent<Button>().onClick.AddListener(() =>
        {
            position.initialValue = new Vector3(-6.69f, 0.19f, -59.31f);
            SceneManager.LoadScene("Podcast");
        });

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
