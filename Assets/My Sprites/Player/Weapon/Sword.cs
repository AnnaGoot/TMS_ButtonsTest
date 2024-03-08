using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public Transform handPosition;

    private Vector3 startPos;
    private Quaternion startRot;
    private bool isGrabbed = false;

    void Start()
    {
        startPos = transform.position;
        startRot = transform.rotation;
    }

    public void WithdrawingSword()
    {
        transform.SetParent(handPosition);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;
        isGrabbed = true;

    }

    public void SheathingSword()
    {
        transform.SetParent(null);
        transform.localPosition = startPos;
        transform.localRotation = startRot;
        isGrabbed = false;
    }

}
