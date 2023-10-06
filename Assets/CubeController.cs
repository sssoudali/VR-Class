using UnityEngine;
using Photon.Pun;

public class CubeController : MonoBehaviour
{
    public float jumpForce = 5.0f;
    private Rigidbody cubeRigidbody;

    PhotonView view;
    void Start()
    {
        view = GetComponent<PhotonView>();
        // Get the Rigidbody component attached to the cube
        cubeRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (view.IsMine)
        {
            // Check if the space button is pressed
            if (Input.GetMouseButtonDown(0))
            {
                // Add an upward force to the cube to make it jump
                cubeRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
        }
    }
}
