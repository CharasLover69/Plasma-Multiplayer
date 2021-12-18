using UnityEngine;
using Photon.Pun;


public class RoomManager : MonoBehaviourPunCallbacks
{
    public string roomName = "Room";
    public GameObject camera;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Connecting..");
        
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster();
        
        Debug.Log("Connected to server");

        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        base.OnJoinedLobby();

        Debug.Log("We're in the lobby");
        
        PhotonNetwork.JoinOrCreateRoom(roomName, null, null);
    }

    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        
        GetComponent<PlayerSpawner>().SpawnPlayer();
        camera.SetActive(false);

        Debug.Log("We're connected and in a room!");
    }
}
