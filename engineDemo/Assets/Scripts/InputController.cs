using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    private SimpleCharacterController charController;

    void Awake()
    {
        charController = GetComponent<SimpleCharacterController>();
    }

    private void Update()
    {
        // Get input values
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        bool jump = Input.GetKey(KeyCode.Space);

        charController.ForwardInput = vertical;
        charController.TurnInput = horizontal;
        charController.JumpInput = jump;
    }
}