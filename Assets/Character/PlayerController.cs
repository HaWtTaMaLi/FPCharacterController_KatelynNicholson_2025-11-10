using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private void Start()
    {
        
    }

    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(x, 0f, z);
    }

}
