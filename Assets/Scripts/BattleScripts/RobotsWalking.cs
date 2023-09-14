using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;
using sr;

public class RobotsWalking : MonoBehaviour
{
    [Header("Walking")]
    [SerializeField] private float sensX = 100f;
    [SerializeField] private float speed = 6f;
    [SerializeField] private float rotateSpeed = 3f;
    private float _yRotation;
    private float _xRotation;
    [Header("")]
    [SerializeField] private Camera cam;
    [SerializeField] private Transform center;
    [SerializeField] private Transform tower;
    [SerializeField] private Transform chassis;

    private Rigidbody rb;

    private void Start()
    {
        Instantiate(new GameObject());
        //Cursor.lockState = CursorLockMode.Locked;
    }
    private void FixedUpdate()
    {
        rb = GetComponent<Rigidbody>();

        GetInput();
        GetInputMouse();
        float moveVertical = Input.GetAxis("Vertical");
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
        rb.velocity = movement * speed;
        /*
        Vector3 movementV = transform.forward * moveVertical * speed * Time.deltaTime;
        rb.MovePosition(rb.position + movementV);
        Vector3 movementH = transform.right * moveHorizontal * speed * Time.deltaTime;
        rb.MovePosition(rb.position + movementH);*/
    }
    private void OnCollisionStay(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            // Calculate the movement vector projected onto the contact surface
            Vector3 projectedMovement = Vector3.Project(rb.velocity, contact.normal);

            // Subtract the projected movement from the current velocity
            rb.velocity -= projectedMovement;
        }
    }

    private void GetInput()
    {

        if (Input.GetKey(KeyCode.W))
        {
            float y = Mathf.LerpAngle(chassis.eulerAngles.y, tower.eulerAngles.y, rotateSpeed * Time.deltaTime);
            chassis.eulerAngles = new Vector3(chassis.eulerAngles.x, y, chassis.eulerAngles.z);
        }

        if (Input.GetKey(KeyCode.S))
        {
            float y = Mathf.LerpAngle(chassis.eulerAngles.y, tower.eulerAngles.y - 180, rotateSpeed * Time.deltaTime);
            chassis.eulerAngles = new Vector3(chassis.eulerAngles.x, y, chassis.eulerAngles.z);
        }

        if (Input.GetKey(KeyCode.A))
        {
            float y = Mathf.LerpAngle(chassis.eulerAngles.y, tower.eulerAngles.y - 90, rotateSpeed * Time.deltaTime);
            chassis.eulerAngles = new Vector3(chassis.eulerAngles.x, y, chassis.eulerAngles.z);
        }

        if (Input.GetKey(KeyCode.D))
        {
            float y = Mathf.LerpAngle(chassis.eulerAngles.y, tower.eulerAngles.y  + 90, rotateSpeed * Time.deltaTime);
            chassis.eulerAngles = new Vector3(chassis.eulerAngles.x, y, chassis.eulerAngles.z);
        }
    }

    private void GetInputMouse()
    {
        var inputX = Input.GetAxis("Mouse X") * Time.deltaTime * sensX;

        _yRotation += inputX;
        _xRotation = Mathf.Clamp(_xRotation, -90f, 90f);

        transform.rotation = Quaternion.Euler(_xRotation, _yRotation, 0);
    }
}