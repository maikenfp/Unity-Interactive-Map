using UnityEngine;

// This script changes the colour of an object using Lerp


public class ChangeColor : MonoBehaviour
{
    // Reference to the objects component
    MeshRenderer cubeMeshRenderer;

    // Speed of the color changes (between 0 and 1)
    [SerializeField] [Range(0f, 1f)] float lerpTime;

    // Array of colors transition between
    [SerializeField] Color[] myColors;

    // Index of the current color in the array
    int colorIndex = 0;

    // Current progress of the color transition
    float time = 0f;

    // length of Array
    int len;

    // Start is called before the first frame update
    void Start()
    {
        // Get MashRenderer attached to same gameobject
        cubeMeshRenderer = GetComponent<MeshRenderer>();

        // Store the length of the array
        len = myColors.Length;
    }

    // Update is called once per frame
    void Update()
    {
        // Transition the object color using Lerp
        cubeMeshRenderer.material.color = Color.Lerp(cubeMeshRenderer.material.color, myColors[colorIndex], lerpTime * Time.deltaTime);

        // Update the time value based on Lerptime and Deltatime
        time = Mathf.Lerp(time, 1f, lerpTime * Time.deltaTime);

        // Check if color transition is close teo completion
        if (time > .9f)
        {
            // Reset time value
            time = 0f;
            // Move to next color
            colorIndex++;
            // If the index exceeds the length of the array, wrap around to the beginning
            colorIndex = (colorIndex >= len) ? 0 : colorIndex;
        }
    }
}
