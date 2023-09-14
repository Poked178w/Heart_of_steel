using UnityEngine;

public class ProjectileAnger : MonoBehaviour
{
    [SerializeField] private float destroyDelay = 0f; // ��������
    [SerializeField] private float getDestroyTime = 0.55f; // ���������� ��������� ��������
    [SerializeField] private float destroyTime = 0.55f; // ��������� �������� �� �������

    public GameObject bullet;

    void Update()
    {
        destroyTime = destroyTime - Time.deltaTime;
        if ( destroyTime <= 0 )
        {
            destroyTime = getDestroyTime;
            DestroyBullet();
        }
    }
        private void OnCollisionExit(Collision collision)
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