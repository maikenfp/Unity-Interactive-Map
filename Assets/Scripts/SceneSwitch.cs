using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Class <c>SceneSwitch</c> switching from one scene to another
/// </summary>
public class SceneSwitch : MonoBehaviour
{
    /// <param name="sceneName"> name of the scene player are comming in </param>
    public string sceneName;

    /// <param name="switchedPosition"> ScriptableObject of the player position </param>
    public VectorValue switchedPosition;

    /* Checks what scene to load based on the name given. Sets the player position
     * accordingly so the player spawns by the doors in each room*/
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
            //Top door
            if (gameObject.tag == "FabLabTop")
            {
                switchedPosition.initialValue = new Vector3(-5.2f, 0.01f, 8f);
                SceneManager.LoadScene("FabLab");
            }
            //Bottom door
            else if (gameObject.tag == "FabLabBottom")
            {
                switchedPosition.initialValue = new Vector3(-6.44f, 0.01f, -8.33f);
                SceneManager.LoadScene("FabLab");
            }
        }

        //----------------MAKERSPACE--------------
        else if (sceneName == "MakerSpace")
        {
            //Top door
            if (gameObject.tag == "MakerSpaceTop")
            {
                switchedPosition.initialValue = new Vector3(-1.19f, 0.72f, 5.3f);
                SceneManager.LoadScene(sceneName);
            }
            //Bottom door
            else if(gameObject.tag == "MakerSpaceBottom")
            {
                switchedPosition.initialValue = new Vector3(-1.19f, 0.72f, -7.62f);
                SceneManager.LoadScene(sceneName);
            }
        }

        /* Checks the door tag to set the player position
        * correctly so the player spawns by the right door when going back to the school
        EX: If the door tag is "podcast" the script will know to position the player by the podcast
        door when the school scene has loaded*/
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

            //Top door
            if (gameObject.tag == "MakerSpaceTop")
            {
                switchedPosition.initialValue = new Vector3(10.33f, 0.01f, -29);
                SceneManager.LoadScene(sceneName);
            }
            //Bottom door
            else if (gameObject.tag == "MakerSpaceBottom")
            {
                switchedPosition.initialValue = new Vector3(10.33f, 0.01f, -50.41f);
                SceneManager.LoadScene(sceneName);
            }

            //Top door
            if (gameObject.tag == "FabLabTop")
            {
                switchedPosition.initialValue = new Vector3(23.05f, 0.01f, -29.57f);
                SceneManager.LoadScene(sceneName);
            }
            //Bottom door
            else if (gameObject.tag == "FabLabBottom")
            {
                switchedPosition.initialValue = new Vector3(22.15f, 0.01f, -50.41f);
                SceneManager.LoadScene(sceneName);
            }
        }
    }
}
