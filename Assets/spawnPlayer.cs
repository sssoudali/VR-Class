using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPlayer : MonoBehaviourPunCallbacks
{
    // Find all GameObjects in the scene with the given name

    public GameObject player;
    public Transform[] positions;

    // Start is called before the first frame update
    void Start()
    {
      PhotonNetwork.Instantiate(player.name, positions[PhotonNetwork.LocalPlayer.ActorNumber - 2].position, positions[PhotonNetwork.LocalPlayer.ActorNumber - 2].rotation);  
    }
 
}
