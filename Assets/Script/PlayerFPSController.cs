using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[RequireComponent(typeof(CharacterMovement))]
[RequireComponent(typeof(MouseLook))]

public class PlayerFPSController : MonoBehaviour
{
    private CharacterMovement characterMovement;
    private MouseLook mouseLook;

    

    // Start is called before the first frame update
    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        GameObject.Find("Capsule").gameObject.SetActive(false);

        characterMovement = GetComponent<CharacterMovement>();
        mouseLook = GetComponent<MouseLook>();
    }

    // Update is called once per frame
    private void Update()
    {
        movement();
        rotation();
    }
    private void movement()
    {

        float hMovementInput = Input.GetAxisRaw("Horizontal");
        float vMovementInput = Input.GetAxisRaw("Vertical");

        bool jumpInput = Input.GetButtonDown("Jump");
        bool dashInput = Input.GetButton("Dash");
    }

    private void rotation()
    {
        float hRotationInput = Input.GetAxis("Mouse X");
        float vRotationInput = Input.GetAxis("Mouse Y");

        mouseLook.handleRotation(hRotationInput, vRotationInput);
    }
}
