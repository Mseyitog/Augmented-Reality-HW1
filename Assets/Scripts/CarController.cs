using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private FixedJoystick fixedJoystick;
    private Rigidbody rigidBody;
    // private Transform cameraTransform;

    private void OnEnable()
    {
        fixedJoystick = FindObjectOfType<FixedJoystick>();
        rigidBody = GetComponent<Rigidbody>();
        // cameraTransform = Camera.main.transform;
    }

    private void FixedUpdate()
    {
        float xVal = fixedJoystick.Horizontal;
        float yVal = fixedJoystick.Vertical;

        float moveMagnitude = new Vector3(xVal, 0, yVal).magnitude;

        // Ensure the car always moves forward based on its current rotation.
        Vector3 forwardMovement = transform.forward * moveMagnitude * speed;

        rigidBody.linearVelocity = forwardMovement;

        // Vector3 movement = new Vector3(xVal, 0, yVal);
        // rigidBody.velocity = movement * speed;

        if (xVal != 0 || yVal != 0)
        {
            Debug.Log("Joystick X: " + xVal + " Y: " + yVal);
            float angle = Mathf.Atan2(xVal, yVal) * Mathf.Rad2Deg;
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, angle, transform.eulerAngles.z);
        }

        // Vector3 cameraForward = Vector3.Scale(cameraTransform.forward, new Vector3(1, 0, 1)).normalized;
        // Vector3 cameraRight = Vector3.Scale(cameraTransform.right, new Vector3(1, 0, 1)).normalized;

        // // Create a movement direction based on joystick input and camera orientation
        // Vector3 movement = (cameraForward * yVal + cameraRight * xVal).normalized;

        // // Move the car
        // rigidBody.velocity = movement * speed;

        // // Rotate the car to face the movement direction
        // if (movement != Vector3.zero)
        // {
        //     transform.rotation = Quaternion.LookRotation(movement);
        // }

        // Debug.Log("Car position: " + carInstance.transform.position);

        // Vector3 direction = Vector3.forward * fixedJoystick.Vertical + Vector3.right * fixedJoystick.Horizontal;
    }
}
