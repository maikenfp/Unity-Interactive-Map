using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Class <c>SwitchingScenesFromSchool</c> switching from one scene to another
/// </summary>
public class SwitchingScenesFromSchool : MonoBehaviour
{
    /// <param name="sceneName"> name of the scene player are comming in </param>
    public string sceneName;

    /// <param name="switchedPosition"> ScriptableObject of the player position </param>
    public VectorValue switchedPosition;

    private void OnTriggerEnter(Collider other)
    {
        //----------------PODCAST--------------
        if(sceneName == "Podcast")
        {
            switchedPosition.initialValue = new Vector3(-6.69f, 0.19f, -59.31f);
            SceneManager.LoadScene(sceneName);
        }

        //----------------ROBOTLAB--------------
        else if (sceneName == "RobotLab")
        {
                switchedPosition.initialValue = new Vector3(-0.74f, 1.3f, -9.54f);
                SceneManager.LoadScene("RobotLab");
        }

        //----------------VR ROOM--------------
        else if (sceneName == "VR_Room")
        {
            switchedPosition.initialValue = new Vector3(-3.12f, 0.01f, -4.21f);
            SceneManager.LoadScene("VR_Room");
        }

        //----------------FABLAB--------------
        else if (sceneName == "FabLab")
        {
            //øverste døren
            if (gameObject.tag == "FabLabTop")
            {
                switchedPosition.initialValue = new Vector3(-5.2f, 0.01f, 8f);
                SceneManager.LoadScene("FabLab");
            }
            //nederste døren
            else if (gameObject.tag == "FabLabBottom")
            {
                switchedPosition.initialValue = new Vector3(-6.44f, 0.01f, -8.33f);
                SceneManager.LoadScene("FabLab");
            }
        }

        //----------------MAKERSPACE--------------
        else if (sceneName == "MakerSpace")
        {
            //øverste døren
            if (gameObject.tag == "MakerSpaceTop")
            {
                switchedPosition.initialValue = new Vector3(-1.19f, 0.72f, 5.3f);
                SceneManager.LoadScene(sceneName);
            }
            //nederste døren
            else if(gameObject.tag == "MakerSpaceBottom")
            {
                switchedPosition.initialValue = new Vector3(-1.19f, 0.72f, -7.62f);
                SceneManager.LoadScene(sceneName);
            }
        }

        //----------------SKOLEN--------------
        else if (sceneName == "Skole")
        {
            if (gameObject.tag == "Podcast")
            {
                switchedPosition.initialValue = new Vector3(-5.89f, 0.01f, -62.56f);
                SceneManager.LoadScene(sceneName);
            }

            else if (gameObject.tag == "RobotLab")
            {
                switchedPosition.initialValue = new Vector3(19.23f, 0.01f, -24.03f);
                SceneManager.LoadScene(sceneName);
            }

            else if (gameObject.tag == "VR_Room")
            {
                switchedPosition.initialValue = new Vector3(42.2f, 0.01f, -24.03f);
                SceneManager.LoadScene(sceneName);
            }

            //øverste døren
            if (gameObject.tag == "MakerSpaceTop")
            {
                switchedPosition.initialValue = new Vector3(10.33f, 0.01f, -29);
                SceneManager.LoadScene(sceneName);
            }
            //nederste døren
            else if (gameObject.tag == "MakerSpaceBottom")
            {
                switchedPosition.initialValue = new Vector3(10.33f, 0.01f, -50.41f);
                SceneManager.LoadScene(sceneName);
            }

            //øverste døren
            if (gameObject.tag == "FabLabTop")
            {
                switchedPosition.initialValue = new Vector3(23.05f, 0.01f, -29.57f);
                SceneManager.LoadScene(sceneName);
            }
            //nederste døren
            else if (gameObject.tag == "FabLabBottom")
            {
                switchedPosition.initialValue = new Vector3(22.15f, 0.01f, -50.41f);
                SceneManager.LoadScene(sceneName);
            }
        }
    }
}
