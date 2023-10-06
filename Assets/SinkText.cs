using Photon.Pun;
using UnityEngine;
using TMPro;
using Photon.Realtime;
using Photon.Pun.UtilityScripts;
using System.Net;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.Collections;

public class SinkText : MonoBehaviour //, IPunObservable
{
    public class StudentState
    {
        public string student_state;
    }
    private PhotonView photonView;

    private TextMeshProUGUI text;
    string apiUrl = "http://127.0.0.1:8080";
    public string write;
    private void Awake()
    {
        photonView = GetComponent<PhotonView>();
        write = "Low";
    }

    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        //  StartTimer();
    }
    private void Update()
    {
        PhotonNetwork.LocalPlayer.NickName = write;
        text.text = write;
        StartCoroutine(GetDataFromAPI());
        //print(PhotonNetwork.LocalPlayer.NickName);
    }

    //private void StartTimer()
    //{

    //    photonView.RPC("SyncTimer3", RpcTarget.AllBuffered, write);
    //}

    //[PunRPC]
    //private void SyncTimer3(string w)
    //{
    //    write = w;
    //}

    //public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    //{
    //    if (stream.IsWriting)
    //    {
    //        // Sending data to other clients
    //        stream.SendNext(write);

    //    }
    //    else if (stream.IsReading)
    //    {
    //        // Receiving data from the owner and updating text for other clients
    //       write = (string)stream.ReceiveNext();
    //    }
    //}

    private IEnumerator GetDataFromAPI()
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(apiUrl))
        {
            yield return webRequest.SendWebRequest();
            if (webRequest.result != UnityWebRequest.Result.Success)
            {
                Debug.LogError("Error while sending request: " + webRequest.error);
            }
            else
            {
                string responseText = webRequest.downloadHandler.text;
                 Debug.Log("API Response: " + responseText);
                StudentState studentstate = JsonUtility.FromJson<StudentState>(responseText);
                Debug.Log("Attention: " + studentstate.student_state);
                write = studentstate.student_state;
                print(write);

            }
        }


    }

}
