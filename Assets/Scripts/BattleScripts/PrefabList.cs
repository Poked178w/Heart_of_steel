using UnityEngine;
using System.Collections.Generic;

public class PrefabList : MonoBehaviour
{
    public List<GameObject> objectPrafabList = new List<GameObject>();

    // Добавляет префабы в список в Инспекторе или программно
    private void Start()
    {
        // Добавляет префабы в список программно
        GameObject warrion = Resources.Load<GameObject>("Warrion");
        GameObject krolik = Resources.Load<GameObject>("Krolik");
        GameObject shot = Resources.Load<GameObject>("Shot");

        objectPrafabList.Add(warrion);
        objectPrafabList.Add(krolik);
        objectPrafabList.Add(shot);
    }
}

// Скрипт пока не доработан