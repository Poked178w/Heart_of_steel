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
        // Получить ссылку на основную камеру
        mainCamera = Camera.main;
    }

    private void Update()
    {
        // Направьте луч из камеры в положение мыши
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        // Объявите переменную RaycastHit для хранения информации о попадании raycast.
        RaycastHit hit;

        // Выполните raycast и проверьте, попадает ли он во что-либо в пределах указанного maxAimDistance
        if (Physics.Raycast(ray, out hit, maxAimDistance))
        {
            // Получите хит-пойнт
            Vector3 hitPoint = hit.point;

            // Рассчитать направление от позиции оружия до точки поражения
            // Поверните оружие в направлении прицеливания
            Vector3 aimDirection1 = hitPoint - weaponTransform1.position;
            weaponTransform1.rotation = Quaternion.LookRotation(aimDirection1);
            Vector3 aimDirection2 = hitPoint - weaponTransform2.position;
            weaponTransform2.rotation = Quaternion.LookRotation(aimDirection2);
            Vector3 aimDirection3 = hitPoint - weaponTransform3.position;
            weaponTransform3.rotation = Quaternion.LookRotation(aimDirection3);
        }
    }
}