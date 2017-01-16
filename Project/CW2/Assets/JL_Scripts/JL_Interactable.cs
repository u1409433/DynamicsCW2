using UnityEngine;
using System.Collections;
using DG.Tweening;
using UnityEngine.Networking;

public class JL_Interactable : NetworkBehaviour
{
    public GameObject GO_Interactable;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    [Command]
    public void CmdInteract(GameObject vPlayer)
    {
        JL_PCControl mSC_PC = vPlayer.GetComponent<JL_PCControl>();
        if (gameObject.name == "Pickup")
        {
            gameObject.transform.localScale = new Vector3(2, 2, 2);
            gameObject.transform.SetParent(vPlayer.transform);
            mSC_PC.SetChild(gameObject);
        }
        else if (gameObject.name == "Open Door")
        {
            gameObject.transform.DOMove(transform.position + new Vector3(0, 3, 0), 3);
        }
        /*else if (gameObject.name == "Locked Door")
        {
            if (mSC_PC.mBL_KeyHeld == true)
            {
                gameObject.transform.name = "Open Door";
                mSC_PC.mBL_KeyHeld = false;
                Debug.Log("Door Unlocked");
            }
        }*/
        else if (gameObject.name == "Alarm Button")
        {
            foreach (GameObject Stormtrooper in GameObject.FindGameObjectsWithTag("StormTrooper"))
            {
                Stormtrooper.SendMessage("Alarm");
            }
        }
        else if (gameObject.name == "Bridge Control")
        {
            Debug.Log("You Win");
        }
    }
}
