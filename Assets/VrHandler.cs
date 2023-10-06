using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VrHandler : MonoBehaviour
{
    //public GameObject connect;
    //public GameObject Join;

    public GameObject connect;
    // Start is called before the first frame update
    void Start()
    {
        connect.SetActive(false);
        //connect.SetActive(true);
        //Join.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //if(connectServer.connected)
        //{
        //    connect.SetActive(false);
        //    Join.SetActive(true);
        //}
    }

    public void startConnect()
    {
        connect.SetActive(true);
    }
}
