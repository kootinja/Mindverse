using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Transform playerCamera;
    public Rigidbody2D rb = new Rigidbody2D();
    Vector3 cameraPOS = new Vector3(0f,0f,-10f);

    private void Update()
    {
        cameraPOS.x = rb.position.x;
        cameraPOS.y = rb.position.y;

        playerCamera.position = cameraPOS;
    }
}
