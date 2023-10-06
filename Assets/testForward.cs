using UnityEngine;
using UnityEngine.XR;

public class testForward : MonoBehaviour
{
    private CharacterController characterController;
    public float moveSpeed = 1.0f;
    public GameObject origin;
    public GameObject origin11;
    private void Start()
    {
        //characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
                Vector3 currentRotation = transform.localRotation.eulerAngles;
                Vector3 currentRotation12 = origin11.transform.rotation.eulerAngles;
        // Freeze the X and Z rotations while allowing Y rotation
            currentRotation.x = -currentRotation12.x;
            currentRotation.z = -currentRotation12.z;
        // Apply the updated rotation to the child GameObject
        transform.localRotation = Quaternion.Euler(currentRotation);
       // Vector2 thumbstickInput = Input.GetAxis("Oculus_LeftThumbstick");
 
        // Check if the thumbstick is pushed forward
        //if (thumbstickInput.y > 0.1f)
       // if (Input.GetKeyDown(KeyCode.A))
       // {
            // Calculate the forward movement vector based on the thumbstick input
            //Vector3 moveDirection = Camera.main.transform.forward * moveSpeed * Time.deltaTime;
           // characterController.Move(moveDirection);

        // transform.rotation = origin.transform.rotation;
        // transform.position = new Vector3(origin.transform.position.x, transform.position.y ,origin.transform.position.z - 0.2f);
        // origin11.transform.position = new Vector3(origin11.transform.position.x, transform.position.y, origin11.transform.position.z);
        // }
    }
}
