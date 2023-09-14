using UnityEngine;

public class AimController : MonoBehaviour
{
    public Transform weaponTransform1;
    public Transform weaponTransform2;
    public Transform weaponTransform3;
    public float maxAimDistance = 100f;

    public Camera mainCamera;

    private void Start()
    {
        // �������� ������ �� �������� ������
        mainCamera = Camera.main;
    }

    private void Update()
    {
        // ��������� ��� �� ������ � ��������� ����
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        // �������� ���������� RaycastHit ��� �������� ���������� � ��������� raycast.
        RaycastHit hit;

        // ��������� raycast � ���������, �������� �� �� �� ���-���� � �������� ���������� maxAimDistance
        if (Physics.Raycast(ray, out hit, maxAimDistance))
        {
            // �������� ���-�����
            Vector3 hitPoint = hit.point;

            // ���������� ����������� �� ������� ������ �� ����� ���������
            // ��������� ������ � ����������� ������������
            Vector3 aimDirection1 = hitPoint - weaponTransform1.position;
            weaponTransform1.rotation = Quaternion.LookRotation(aimDirection1);
            Vector3 aimDirection2 = hitPoint - weaponTransform2.position;
            weaponTransform2.rotation = Quaternion.LookRotation(aimDirection2);
            Vector3 aimDirection3 = hitPoint - weaponTransform3.position;
            weaponTransform3.rotation = Quaternion.LookRotation(aimDirection3);
        }
    }
}