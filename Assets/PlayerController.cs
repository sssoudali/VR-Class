using UnityEngine;
using Photon.Pun;

public class PlayerController : MonoBehaviourPun
{
    private Camera playerCamera;

    void Start()
    {
        //if (photonView.IsMine) // Check if this object belongs to the local player
        //{
        //    // Create a new camera for the player
            playerCamera = GetComponentInChildren<Camera>();
        //    playerCamera.GetComponent<Camera>().cullingMask = LayerMask.GetMask("Player"); // Set culling mask to only show player layer
        //}
    }

    void Update()
    {
        if (photonView.IsMine) // Check if this object belongs to the local player
        {
            // Update 
        }
        else
        {
            playerCamera.GetComponent<Camera>().enabled = false; // Disable the camera if it doesn't belong to the local player
        }
    }
}
