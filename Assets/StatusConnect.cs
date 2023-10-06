using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StatusConnect : MonoBehaviour
{
    public TextMeshProUGUI status;
    // Start is called before the first frame update
    void Start()
    {
       // status.text = "Connecting to Server";
    }

    // Update is called once per frame
    void Update()
    {
        //if (PlayerPrefs.GetInt("status") == 1)
        //{
        //    status.text = "Connected";
            
        //    status.text = "Finding Room to Join!";
        //}
        //if (PlayerPrefs.GetInt("status") == 2)
        //{
        //    status.text = "Ready to Join!";
        //}
    }
}
