using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //reference camera

    //steps are .5 height
    //jump is 1
    //Ramps 
    //wasd

    //Look Direction
    //public float mouseX;
    //public float mouseY;
    public float xRotation = 0f;
    public float mouseSensitivity = 100f;


    //Player
    public Transform playerBody;

    //Actions
    public int speed = 5;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity + Time.deltaTime;

        xRotation -= mouseY;
        //clamp
        xRotation = Mathf.Clamp(xRotation, -90f, 90); //min and max look

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
