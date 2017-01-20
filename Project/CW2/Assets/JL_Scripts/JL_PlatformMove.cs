using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class JL_PlatformMove : MonoBehaviour
{
    public float FL_Speed;
    public float FL_Target1;
    public float FL_Target2;

    private bool BL_Active = true;

    // Use this for initialization
    void Start()
    {
        Sequence BackandForth = DOTween.Sequence();
        BackandForth.Append(transform.DOMoveX(FL_Target1, FL_Speed));
        BackandForth.Append(transform.DOMoveX(FL_Target2, FL_Speed));
        BackandForth.SetLoops(-1);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Activate()
    {
        BL_Active = false;
        Invoke("RestoreMovement", 3);
    }

    void RestoreMovement()
    {

    }

}
