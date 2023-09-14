//#define TestMoveRays
using System;
using UnityEngine;
using UnityEngine.UIElements;

public class RobotController_test : MonoBehaviour
{
    [Serializable]
    private class RayCastObjects
    {
        [SerializeField]
        internal GameObject sphMiddle;
        [SerializeField]
        internal GameObject sphMiddleCast;
    }
    [Serializable]
    private class RayOffsets
    {
        [SerializeField]
        internal float sphMiddle = 0.4f;
    }
    [SerializeField]
    private RayCastObjects rayCasts = new RayCastObjects();
    [SerializeField]
    private RayOffsets rayOffsets = new RayOffsets();

    public float gravity = 0f;
    public float movementSpeed = 4f;
    public float topRotationDamping = 1f;
    public float bodyRotationDamping = 1f;
    public Vector3 FollowCamRotation;

    private Rigidbody rigBody;

    [SerializeField] private Transform tower;
    [SerializeField] private Transform chassis;
    float yTopRot;
    bool isInAir;

    void Start()
    {
        rigBody = this.GetComponent<Rigidbody>();
        if (rigBody == null)
        {
            Debug.LogError("Error: rigBody = null!");
        }
    }

    void FixedUpdate()
    {
        RotateTop();
        RotateBody();
        //SlopeSheking();
        if (PlayerInput.isHorizontalOrVertical )
        {
            Move();
        }
    }

    void Move()
    {
        Vector3 move = transform.TransformDirection(chassis.forward * movementSpeed);
        rigBody.MovePosition(rigBody.velocity + move * Time.deltaTime);
    }


    /*void SlopeSheking()
    {
        Vector3 upOffset = this.transform.position + this.transform.up * rayOffsets.sphMiddle;
        Probe reyMiddle = MakeRaycastDown(upOffset);
        isInAir = reyMiddle.hitResult.distance > rayOffsets.sphMiddle;
        if (!isInAir)
        {
            rigBody.useGravity = false;
            rigBody.MovePosition(new Vector3(rigBody.position.x, reyMiddle.hitResult.point.y + 1, rigBody.position.x));
        }
        else
        {
            rigBody.useGravity = true;
        }

        #if TestMoveRays
        rayCasts.sphMiddle.transform.position = reyMiddle.hitRay.origin;
        rayCasts.sphMiddleCast.transform.position = reyMiddle.hitResult.point;
        #endif
    }*/
    void RotateTop()
    {
        yTopRot = Mathf.LerpAngle(tower.eulerAngles.y, FollowCamRotation.y, topRotationDamping * (1 - Mathf.Exp(-20 * Time.fixedDeltaTime)));
        tower.eulerAngles = new Vector3(tower.eulerAngles.x, yTopRot, tower.eulerAngles.z);
        //rigBody.rotation = Quaternion.Euler(new Vector3(0, yTopRot, 0));
    }
    void RotateBody()
    {
        if (Input.GetKey(KeyCode.W))
        {
            float y = Mathf.LerpAngle(chassis.eulerAngles.y, tower.eulerAngles.y, bodyRotationDamping * Time.deltaTime);
            chassis.eulerAngles = new Vector3(chassis.eulerAngles.x, y, chassis.eulerAngles.z);
        }

        if (Input.GetKey(KeyCode.S))
        {
            float y = Mathf.LerpAngle(chassis.eulerAngles.y, tower.eulerAngles.y - 180, bodyRotationDamping * Time.deltaTime);
            chassis.eulerAngles = new Vector3(chassis.eulerAngles.x, y, chassis.eulerAngles.z);
        }

        if (Input.GetKey(KeyCode.A))
        {
            float y = Mathf.LerpAngle(chassis.eulerAngles.y, tower.eulerAngles.y - 90, bodyRotationDamping * Time.deltaTime);
            chassis.eulerAngles = new Vector3(chassis.eulerAngles.x, y, chassis.eulerAngles.z);
        }

        if (Input.GetKey(KeyCode.D))
        {
            float y = Mathf.LerpAngle(chassis.eulerAngles.y, tower.eulerAngles.y + 90, bodyRotationDamping * Time.deltaTime);
            chassis.eulerAngles = new Vector3(chassis.eulerAngles.x, y, chassis.eulerAngles.z);
        }
    }
    /*private Probe MakeRaycastDown(Vector3 origin)
    {
        Probe p = new Probe();
        p.hitRay = new Ray(origin, Vector3.down);
        Physics.Raycast(p.hitRay, out p.hitResult, 100f);
        return p;
    } 
    public struct Probe
    {
        public Ray hitRay;
        public RaycastHit hitResult;
    }  */
}
