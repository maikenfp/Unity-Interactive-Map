using TMPro;
using UnityEngine;

/// <summary>
/// Class <c>ObjectInteraction</c> UI for evry interactebel object
/// </summary>
public class ObjectInteraction : MonoBehaviour
{
    /// <param name="objectDescriptionBox"> GameObject containing UI element</param>
    public GameObject objectDescriptionBox;

    /// <param name="interactTipBox"> GameObject containing UI element </param>
    public GameObject interactTipBox;

    /// <param name="image"> GameObject containing UI element </param>
    public GameObject image;

    /// <param name="objectDescriptionText"> UI text </param>
    public TMP_Text objectDescriptionText;

    /// <param name="objectDescriptionHeadline"> UI text </param>
    public TMP_Text objectDescriptionHeadline;

    /// <param name="playerInRange"> activate if player is in range </param>
    public bool playerInRange;

    private void Update()
    {
        /* Checks if the player is in range of the object with the script, if true,
         * the pop up boxes appear*/
        if (playerInRange)
        {
            interactTipBox.SetActive(true);
            if (Input.GetKeyDown(KeyCode.F))
            {
                interactTipBox.SetActive(false);
                if (objectDescriptionBox.activeInHierarchy)
                {
                    objectDescriptionBox.SetActive(false);
                    image.SetActive(false);
                }
                else
                {
                    objectDescriptionBox.SetActive(true);
                    image.SetActive(true);
                }
            }
        }
        //If player is not in range, hide all pop up boxes
        else
        {
            interactTipBox.SetActive(false);
            objectDescriptionBox.SetActive(false);
            image.SetActive(false);
        }
    }

    /*Will only trigger if the gameobject has the tag "Player" to
     * distinguish the player from other gameobjects */
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }
}
