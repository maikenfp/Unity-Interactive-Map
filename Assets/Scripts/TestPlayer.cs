using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Class <c>TestPlayer</c> player movment add this to the player
/// </summary>
public class TestPlayer : MonoBehaviour
{
    /// <param name="startingPosition"> ScriptableObject of the player position</param>
    public VectorValue startingPosition;

    /// <param name="animator"> animate player</param>
    private Animator animator;

    /// <param name="initPos"> boolion </param>
    private static bool initPos = false;

    /// <param name="moveSpeed"> seed of player</param>
    [SerializeField] public float moveSpeed;

    /// <param name="changedegres"> sett to ScriptableObject</param>
    [SerializeField]
    DegreisScriptabelObject changedegres;

    /// <param name="getController"> initlize the controller class</param>
    ControllerKeys getController = new ControllerKeys();

    /// <param name="currentScene"> scene </param>
    Scene currentScene;

    /// <param name="inscene"> to finde the scene the player are in</param>
    string inscene;

    private void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        inscene = currentScene.name;

        animator = GetComponent<Animator>();
        if (initPos == false)
        {
            initPos = true;
            startingPosition.initialValue = new Vector3(-54, 0.1f, -89);
            transform.position = startingPosition.initialValue;
        }
        else
        {
            transform.position = startingPosition.initialValue;
        }

        transform.position = startingPosition.initialValue;
    }

    private void Update()
    {

        Vector2 inputVector = new Vector2(0, 0);

        //use objeckt from ControllerKeys class
        if (inscene != "Skole")
        {
            //change controller
            inputVector = getController.ControllerAngelASWD(inputVector, changedegres.degrees);
            gameObject.transform.eulerAngles = getController.GetAngel();
        }
        else
        {
            changedegres.degrees = 45;

            //defult controller
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                inputVector.y = +1;
                gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
            }

            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                inputVector.y = -1;
                gameObject.transform.eulerAngles = new Vector3(0, 180, 0);
            }
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                inputVector.x = -1;
                gameObject.transform.eulerAngles = new Vector3(0, -90, 0);
            }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                inputVector.x = +1;
                gameObject.transform.eulerAngles = new Vector3(0, 90, 0);
            }
        }


        Vector3 moveDir = new Vector3(inputVector.x, 0f, inputVector.y);
        float playerSize = .3f;
        bool canMove = !Physics.Raycast(transform.position, moveDir, playerSize);

        inputVector = inputVector.normalized;
        if (canMove)
        {
            transform.position += moveDir * moveSpeed * Time.deltaTime;
        }


        if (moveDir != Vector3.zero)
        {
            animator.SetBool("isMoving", true);
        }
        else
        {
            animator.SetBool("isMoving", false);
        }

    }
}