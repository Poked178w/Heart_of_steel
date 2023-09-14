using UnityEngine;

public class ProjectilePiner : MonoBehaviour
{
    [SerializeField] private float destroyDelay = 0.01f; // ��������
    [SerializeField] private float getDestroyTime = 0.9f; // ���������� ��������� ��������
    [SerializeField] private float destroyTime = 0.9f; // ��������� �������� �� �������

    public GameObject bullet;

    void Update()
    {
        destroyTime = destroyTime - Time.deltaTime;
        if (destroyTime <= 0)
        {
            destroyTime = getDestroyTime;
            DestroyBullet();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            // ����������� �� �����
            DestroyBullet();
        }
    }

    private void DestroyBullet()
    {
        // ���������� ����
        GetComponent<Collider>().enabled = false;

        // �������� ����
        Destroy(bullet, destroyDelay);
    }
}