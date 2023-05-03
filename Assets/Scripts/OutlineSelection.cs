using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


/// <summary>
/// Class <c>OutlineSelection</c> sett this script on object with interactebel Dialog
/// </summary>
public class OutlineSelection : MonoBehaviour
{
    /// <param name="highlight"> changes color </param>
    private Transform highlight;

    /// <param name="selection"> if the object dont have outline </param>
    private Transform selection;

    /// <param name="raycastHit"> send a signal to a point on screen </param>
    private RaycastHit raycastHit;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            highlight = transform;
            if (highlight.CompareTag("Selectable") && highlight != selection)
            {
                if (highlight.gameObject.GetComponent<Outline>() != null)
                {
                    highlight.gameObject.GetComponent<Outline>().enabled = true;
                }
                else
                {
                    Outline outline = highlight.gameObject.AddComponent<Outline>();
                    outline.enabled = true;
                    highlight.gameObject.GetComponent<Outline>().OutlineColor = Color.red;
                    highlight.gameObject.GetComponent<Outline>().OutlineWidth = 5.0f;
                }
            }
            else
            {
                highlight = null;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            highlight.gameObject.GetComponent<Outline>().enabled = false;
            highlight = null;
        }
    }

}