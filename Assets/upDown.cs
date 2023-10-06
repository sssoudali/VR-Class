using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upDown : MonoBehaviour
{
    public GameObject g; 
    // Start is called before the first frame update
    void Start()
    {
       
        up = true;
    }

    // Update is called once per frame
    void Update()
    {
        g = GameObject.FindWithTag("teacher");
    }
    public static bool up;
    private void OnTriggerEnter(Collider other)
    {
        up = !up;
        if (up)
        {

                g.transform.position = new Vector3(g.transform.position.x, 0.15f, g.transform.position.z);
            
        }
        else
        {

                g.transform.position = new Vector3(g.transform.position.x, 0f, g.transform.position.z);
            
        }
    }
}
