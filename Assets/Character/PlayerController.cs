using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject Player;
    public int speed = 5;
    public float mouseSensitivity = 100f;

    private void Start()
    {
        
    }

    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        Player.transform.position += move * speed * Time.deltaTime;
    }

}
