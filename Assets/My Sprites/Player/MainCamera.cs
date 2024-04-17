using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    private Transform player;
    public Vector3 offset;

    public float rotationSpeed = 5f;
    //private bool isRotating = false;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

    }

    void Update()
    {
        transform.position = player.position + offset;

        //if (Input.GetMouseButtonDown(0))
        //{
        //    isRotating = true;
        //}
        //else if (Input.GetMouseButtonUp(0))
        //{
        //    isRotating = false;
        //}

        //if (isRotating)
        //{
        //    float mouseX = Input.GetAxis("Mouse X");
        //    float mouseY = Input.GetAxis("Mouse Y");

        //    transform.RotateAround(player.position, Vector3.up, mouseX * rotationSpeed);
        //    transform.RotateAround(player.position, transform.right, -mouseY * rotationSpeed);

        //    Vector3 currentRotation = transform.eulerAngles;
        //    currentRotation.x = Mathf.Clamp(currentRotation.x, 10f, 80f);
        //    transform.eulerAngles = currentRotation;
        //}

    }
}
