using UnityEngine;

public class ProjectileAnger : MonoBehaviour
{
    [SerializeField] private float destroyDelay = 0f; // Задержка
    [SerializeField] private float getDestroyTime = 0.55f; // Установить дальность снарядов
    [SerializeField] private float destroyTime = 0.55f; // Дальность снарядов во времени

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