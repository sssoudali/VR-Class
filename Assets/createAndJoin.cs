using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class createAndJoin : MonoBehaviourPunCallbacks
{
    
    public GameObject g1;
     public TextMeshProUGUI g2;
    void Start()
    {
       g1.SetActive(true);
    g2.enabled = false;
    }
  
    private void Update()
    {
    
    }
   public void CreateRoom()
    {
        // Generate a random room name
        string roomName = "Room" + Random.Range(1000, 9999);

        // Create a new room
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 4; // Set the maximum number of players for the room

        PhotonNetwork.CreateRoom(roomName, roomOptions);
    }

    public override void OnCreatedRoom()
    {
          g1.SetActive(false);
          g2.enabled = true;
          g2.text = PhotonNetwork.CurrentRoom.Name;
          Debug.Log("Room created: " + PhotonNetwork.CurrentRoom.Name);
          Invoke("StartGame",10f);
    }

    private void StartGame()
    {
        PhotonNetwork.LoadLevel("class");
    }
}
