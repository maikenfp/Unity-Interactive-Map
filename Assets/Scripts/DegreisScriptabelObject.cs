using UnityEngine;



/// <summary>
/// Class <c>DegreisScriptabelObject</c> ScriptableObject for camera angel with contrllers
/// </summary>
[CreateAssetMenu(menuName = "ChangeDegrees")]
public class DegreisScriptabelObject : ScriptableObject
{
    /// <param name="degrees"> accessible for to change the angel of the camera </param>
    public int degrees;

    /// <param name="changeDegrees"> starting angel </param>
    [SerializeField]
    private int changeDegrees = 45;

    /// <param name="ChangeCameraAngle"> </param>
    [System.NonSerialized]
    public UnityEngine.Events.UnityEvent<int> ChangeCameraAngle;

    private void OnEnable()
    {
        degrees = changeDegrees;
        if (ChangeCameraAngle == null)
            ChangeCameraAngle = new UnityEngine.Events.UnityEvent<int>();

    }

    /// <summary>
    /// when using this methode the camera changes in the rigth direction
    /// </summary>
    public void CameraGoE()
    {
        if (degrees >= 135)
        {
            degrees = -135;
        }
        else
        {
            degrees += 90;
        }

        ChangeCameraAngle.Invoke(degrees);
    }

    /// <summary>
    /// when using this methode the camera changes in the left direction
    /// </summary>
    public void CameraGoQ()
    {
        if (degrees <= -135)
        {
            degrees = 135;
        }
        else
        {
            degrees -= 90;
        }
        ChangeCameraAngle.Invoke(degrees);
    }
}
