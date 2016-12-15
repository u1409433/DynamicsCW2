using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class JL_NetworkManagerExtended : NetworkManager
{
    public static JL_NetworkManagerExtended Manager;

    // Use this for initialization
    void Start()
    {
        Manager = this;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId)
    {
        switch (numPlayers)
        {
            case 0: playerPrefab = spawnPrefabs[0];
                break;
        }

        base.OnServerAddPlayer(conn, playerControllerId);
    }


}
