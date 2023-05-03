using UnityEngine;

/// <summary>
/// Class <c>ChangeColor</c> change color of player when the player is behind somthin
/// </summary>
public class ChangeColor : MonoBehaviour
{
    /// <param name="cubeMeshRenderer"> the color of the player when behind a wall </param>
    MeshRenderer cubeMeshRenderer;

    /// <param name="lerpTime"> number in range between 0 and 1 </param>
    [SerializeField] [Range(0f, 1f)] float lerpTime;

    /// <param name="myColors"> the coler it changes to </param>
    [SerializeField] Color[] myColors;

    /// <param name="myColors"> the coler it changes to </param>
    int colorIndex = 0;

    /// <param name="time">start time </param>
    float time = 0f;

    /// <param name="len"> length </param>
    int len;

    // Start is called before the first frame update
    void Start()
    {
        cubeMeshRenderer = GetComponent<MeshRenderer>();
        len = myColors.Length;
    }

    // Update is called once per frame
    void Update()
    {
        cubeMeshRenderer.material.color = Color.Lerp(cubeMeshRenderer.material.color, myColors[colorIndex], lerpTime * Time.deltaTime);

        time = Mathf.Lerp(time, 1f, lerpTime * Time.deltaTime);
        if (time > .9f)
        {
            time = 0f;
            colorIndex++;
            colorIndex = (colorIndex >= len) ? 0 : colorIndex;
        }
    }
}
