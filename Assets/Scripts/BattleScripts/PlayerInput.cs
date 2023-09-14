using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public static float Horizontal { get; private set; }
    public static float Vertical { get; private set; }
    public static float MouseHorizontal { get; private set; }
    public static float MouseVertical { get; private set; }
    public static bool isHorizontalOrVertical
    {
        get
        {
            return Horizontal != 0 || Vertical != 0;
        }
    }

    public float MouseSensitivity = 1f;

    void Update()
    {
        GetInput();
    }

    private void GetInput()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        Vertical = Input.GetAxisRaw("Vertical");

        MouseHorizontal = Input.GetAxis("Mouse X") * MouseSensitivity;
        MouseVertical = Input.GetAxis("Mouse Y") * MouseSensitivity;
    }
}