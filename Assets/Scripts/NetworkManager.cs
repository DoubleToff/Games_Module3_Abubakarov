using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    public GameObject playerPrefab;

    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinOrCreateRoom("Room1", new RoomOptions { MaxPlayers = 10 }, TypedLobby.Default);
    }

    public override void OnJoinedRoom()
    {
        Vector3 pos = new Vector3(Random.Range(-2f, 2f), 1f, Random.Range(-2f, 2f));
        PhotonNetwork.Instantiate(playerPrefab.name, pos, Quaternion.identity);
    }
}
