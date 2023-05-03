using UnityEngine;


/// <summary>
/// Class <c>CameraContorller</c> controlls the parretn of the camera in diffrent angels depending on the ScriptabelObject
/// </summary>
public class CameraContorller : MonoBehaviour
{
    /// <param name="camChangeDeg"> parrent object having a child with a cammera component </param>
    public GameObject camChangeDeg;

    /// <param name="changedegres"> ScriptableObject holding the camera angel </param>
    [SerializeField]
    public DegreisScriptabelObject changedegres;

    private void OnEnable()
    {
        changedegres.ChangeCameraAngle.AddListener(ChagneCam);
    }

    private void OnDisable()
    {
        changedegres.ChangeCameraAngle.RemoveListener(ChagneCam);
    }

    /// <summary>
    /// sett the camera to a new degre from UIManager
    /// </summary>
    /// <param name="degree"></param>
    public void ChagneCam(int degree)
    {
        camChangeDeg.transform.eulerAngles = new Vector3(30, degree, 0);
    }
}
