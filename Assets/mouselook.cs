using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class mouselook : MonoBehaviour
{
    public Vector2 turn;
    PhotonView view;
    public float rotationSpeed = 10.0f;
    public float xMinAngle = -45.0f;
    public float xMaxAngle = 45.0f;
    public float yMinAngle = -45.0f;
    public float yMaxAngle = 45.0f;

    void Start()
    {
        view = GetComponent<PhotonView>();
        //Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        turn.x += Input.GetAxis("Mouse X") * rotationSpeed / 2.0f;
        turn.y += Input.GetAxis("Mouse Y") * rotationSpeed / 2.0f;
       turn.y = Mathf.Clamp(turn.y, yMinAngle, yMaxAngle);
        turn.x = Mathf.Clamp(turn.x, xMinAngle, xMaxAngle);



        if (turn.x < 45 && turn.x > -45 && turn.y < 70 && turn.y > -2)
        {
            // if (turn.y < 70 && turn.y > -2)
            transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
        }
        //}
    }
}
