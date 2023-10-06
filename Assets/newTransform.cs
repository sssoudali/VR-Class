using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newTransform : MonoBehaviour
{
    public GameObject game;
    // Start is called before the first frame update
    void Start()
    {
        game = GameObject.FindWithTag("teacher");
    }

    // Update is called once per frame
    void Update()
    {
        game = GameObject.FindWithTag("teacher");

        if(game != null)
        {
            game.transform.position = new Vector3(game.transform.position.x,1.55f, game.transform.position.z);
        }
    }
}
