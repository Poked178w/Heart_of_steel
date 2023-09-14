using UnityEngine;

public class ProjectilePuv : MonoBehaviour
{
    [SerializeField] private float destroyDelay = 0.01f; // ��������
    [SerializeField] private float getDestroyTime = 2f; // ���������� ��������� ��������
    [SerializeField] private float destroyTime = 2f; // ��������� �������� �� �������

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