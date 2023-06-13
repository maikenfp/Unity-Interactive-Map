using System.Collections;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// Class <c>UIManagerAngle</c> checking for input on button q and e
/// </summary>
public class UIManagerAngle : MonoBehaviour
{

    /// <param name="changedegres"> ScriptabelObject</param>
    [SerializeField]
    public DegreeScriptabelObject changedegres;

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
        //start Coroutine when script start running 
        StartCoroutine(CountDown(timeDisinc));
    }

    private void FixedUpdate()
    {
        //when click on the E button camrea goes to the rigth
        uiButtonE.GetComponent<Button>().onClick.AddListener(() =>
    {
        StartCoroutine(CountDown(timeDisinc));
        //change camera degrees
        changedegres.CameraGoQ();
    }
    );
        //when click on the E button camrea goes to the left
        uiButtonQ.GetComponent<Button>().onClick.AddListener(() =>
        {
            StartCoroutine(CountDown(timeDisinc));
            changedegres.CameraGoE();
        }
        );

        //if button is already clikked the whait to timer is set to true
        if (Input.GetKey(KeyCode.Q) && !timed)
        {
            StartCoroutine(CountDown(timeDisinc));
            changedegres.CameraGoQ();
        }
        //if button is already clikked the whait to timer is set to true
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
