using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject Player;

    public int speed = 5;

    private void Start()
    {
        
    }

    private void Update()
    {
        float x = Input.GetAxis("Horizontal"); //W && S
        float z = Input.GetAxis("Vertical"); //A && D

        Vector3 move = transform.right * x + transform.forward * z;

        Player.transform.position += move * speed * Time.deltaTime;
    }

}
