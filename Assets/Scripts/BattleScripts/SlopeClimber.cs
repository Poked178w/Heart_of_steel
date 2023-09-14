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
        // Для обнаружения земли или склона нужен Raycast
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 1f))
        {
            // Вычисление угола между нормалью к поверхности и направлением вверх
            float slopeAngle = Vector3.Angle(hit.normal, Vector3.up);

            // Проверка, нахождения угола в допустимом диапазоне
            if (slopeAngle <= maxClimbAngle)
            {
                // Рассчитывает силу подъема на основе угла наклона
                float climbForce = Mathf.Sin(slopeAngle * Mathf.Deg2Rad) * slopeForce;

                // Приложение усилия подъема в направлении, параллельном склону.
                Vector3 climbDirection = Vector3.Cross(hit.normal, transform.right);
                rigBody.AddForce(climbDirection * climbForce, ForceMode.Force);
            }
        }
    }
}

// Тест скрипт пока не доработан