using UnityEngine;

public class CamController : MonoBehaviour
{
    public GameObject robot;
    public float camLag = 1;
    public float camRotationDamping = 4f;

    private Vector3 camTargetRotation;
    private Vector3 camCurrentRotation;

    void Start()
    {
        camCurrentRotation = this.transform.eulerAngles;
        //Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {

    }

    private void FixedUpdate()
    {
        RotateCam();
        InformRobotAboutCamRotation();
        MoveCamAfterRobot();
    }

    void RotateCam()
    {
        camTargetRotation += new Vector3(0, PlayerInput.MouseHorizontal, 0);
        camCurrentRotation.y = Mathf.LerpAngle(camCurrentRotation.y, camTargetRotation.y, camRotationDamping * Time.deltaTime);
        this.transform.eulerAngles = camCurrentRotation;
    }
    void MoveCamAfterRobot()
    {
        Rigidbody robRigBody = robot.GetComponent<Rigidbody>();
        Vector3 robotPosition = new Vector3(robRigBody.position.x, robRigBody.position.y, robRigBody.position.z);
        Vector3 camPosition = Vector3.Lerp(transform.position, robotPosition, Time.deltaTime * camLag);
        transform.position = camPosition;
    }
    void InformRobotAboutCamRotation()
    {
        this.robot.GetComponent<RobotController>().FollowCamRotation = camCurrentRotation;
    }
}
