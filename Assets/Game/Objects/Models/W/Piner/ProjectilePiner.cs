using UnityEngine;

public class ProjectilePiner : MonoBehaviour
{
    [SerializeField] private float destroyDelay = 0.01f; // Задержка
    [SerializeField] private float getDestroyTime = 0.9f; // Установить дальность снарядов
    [SerializeField] private float destroyTime = 0.9f; // Дальность снарядов во времени

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
            // Уничтожение об стену
            DestroyBullet();
        }
    }

    private void DestroyBullet()
    {
        // Отключение пули
        GetComponent<Collider>().enabled = false;

        // Удаление пули
        Destroy(bullet, destroyDelay);
    }
}