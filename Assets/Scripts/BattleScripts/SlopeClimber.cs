using UnityEngine;

public class SlopeClimber : MonoBehaviour
{
    public float slopeForce = 5f;
    public float maxClimbAngle = 45f;

    private Rigidbody rigBody;

    private void Start()
    {
        rigBody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        // ��� ����������� ����� ��� ������ ����� Raycast
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 1f))
        {
            // ���������� ����� ����� �������� � ����������� � ������������ �����
            float slopeAngle = Vector3.Angle(hit.normal, Vector3.up);

            // ��������, ���������� ����� � ���������� ���������
            if (slopeAngle <= maxClimbAngle)
            {
                // ������������ ���� ������� �� ������ ���� �������
                float climbForce = Mathf.Sin(slopeAngle * Mathf.Deg2Rad) * slopeForce;

                // ���������� ������ ������� � �����������, ������������ ������.
                Vector3 climbDirection = Vector3.Cross(hit.normal, transform.right);
                rigBody.AddForce(climbDirection * climbForce, ForceMode.Force);
            }
        }
    }
}

// ���� ������ ���� �� ���������