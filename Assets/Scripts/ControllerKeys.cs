using UnityEngine;


/// <summary>
/// Class <c>ControllerKeys</c> used by the TestPlayer to controll the the diraction player is walking.
/// </summary>
public class ControllerKeys
{
    /// <param name="playerAngle"> store the direaction of the player and returns it with a public method </param>
    private Vector3 playerAngle;


    /// <summary>
    /// Move the player in correct direction depend on the camera angel
    /// </summary>
    /// <param name="inputVector"></param>
    /// <param name="cameraAngel"></param>
    /// <returns>inputVector</returns>
    public Vector2 ControllerAngelASWD(Vector2 inputVector, int cameraAngel)
    {

        if (cameraAngel == 45)
        {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                inputVector.y = +1;
                playerAngle = new Vector3(0, 0, 0);
            }

            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                inputVector.y = -1;
                playerAngle = new Vector3(0, 180, 0);
            }
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                inputVector.x = -1;
                playerAngle = new Vector3(0, -90, 0);
            }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                inputVector.x = +1;
                playerAngle = new Vector3(0, 90, 0);
            }
        }

        if (cameraAngel == -135)
        {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                inputVector.y = -1;
                playerAngle = new Vector3(0, 180, 0);
            }

            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                inputVector.y = +1;
                playerAngle = new Vector3(0, 0, 0);

            }
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                inputVector.x = +1;
                playerAngle = new Vector3(0, 90, 0);

            }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                inputVector.x = -1;
                playerAngle = new Vector3(0, -90, 0);
            }
        }

        if (cameraAngel == -45)
        {

            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                inputVector.x = -1;
                playerAngle = new Vector3(0, -90, 0);
            }

            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                inputVector.x = +1;
                playerAngle = new Vector3(0, 90, 0);
            }
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                inputVector.y = -1;
                playerAngle = new Vector3(0, 180, 0);

            }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                inputVector.y = +1;
                playerAngle = new Vector3(0, 0, 0);
            }
        }

        if (cameraAngel == 135)
        {

            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                inputVector.x = +1;
                playerAngle = new Vector3(0, 90, 0);
            }

            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                inputVector.x = -1;
                playerAngle = new Vector3(0, -90, 0);
            }
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                inputVector.y = +1;
                playerAngle = new Vector3(0, 0, 0);
            }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                inputVector.y = -1;
                playerAngle = new Vector3(0, 180, 0);
            }

        }


        return inputVector;
    }

    /// <summary>
    /// this methode returns the direction the player is facing
    /// </summary>
    /// <returns>playerAngle</returns>
    public Vector3 GetAngel()
    {
        return playerAngle;
    }
}
