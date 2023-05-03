using System.Collections;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// Class <c>UIManagerAngel</c> checking for input on button q and e
/// </summary>
public class UIManagerAngel : MonoBehaviour
{

    /// <param name="changedegres"> ScriptabelObject</param>
    [SerializeField]
    public DegreisScriptabelObject changedegres;

    /// <param name="uiButtonQ"> UI Button</param>
    [SerializeField]
    public GameObject uiButtonQ;

    /// <param name="uiButtonE"> UI Button</param>
    public GameObject uiButtonE;

    /// <param name="timed"> if button is pressed set this to false</param>
    private bool timed;

    /// <param name="timeDisinc"> how long it takes before code can run after Coroutine is called</param>
    private float timeDisinc = 1;

    void Start()
    {
        StartCoroutine(CountDown(timeDisinc));
    }

    private void FixedUpdate()
    {
        uiButtonE.GetComponent<Button>().onClick.AddListener(() =>
    {
        StartCoroutine(CountDown(timeDisinc));

        changedegres.CameraGoQ();
    }
    );

        uiButtonQ.GetComponent<Button>().onClick.AddListener(() =>
        {
            StartCoroutine(CountDown(timeDisinc));
            changedegres.CameraGoE();
        }
        );


        if (Input.GetKey(KeyCode.Q) && !timed)
        {
            StartCoroutine(CountDown(timeDisinc));
            changedegres.CameraGoQ();
        }
        else if (Input.GetKey(KeyCode.E) && !timed)
        {
            StartCoroutine(CountDown(timeDisinc));
            changedegres.CameraGoE();

            uiButtonQ.GetComponent<Button>().onClick.AddListener(() =>
            {
                StartCoroutine(CountDown(timeDisinc));
                changedegres.CameraGoE();
            }
        );
        }
    }

    /// <summary>
    /// run code after a delay
    /// </summary>
    /// <param name="deleyUpdate"></param>
    IEnumerator CountDown(float deleyUpdate)
    {
        timed = true;
        yield return new WaitForSeconds(deleyUpdate);
        timed = false;
    }
}
