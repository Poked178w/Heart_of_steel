using UnityEngine;
using System.Collections.Generic;

public class PrefabList : MonoBehaviour
{
    public List<GameObject> objectPrafabList = new List<GameObject>();

    // ��������� ������� � ������ � ���������� ��� ����������
    private void Start()
    {
        // ��������� ������� � ������ ����������
        GameObject warrion = Resources.Load<GameObject>("Warrion");
        GameObject krolik = Resources.Load<GameObject>("Krolik");
        GameObject shot = Resources.Load<GameObject>("Shot");

        objectPrafabList.Add(warrion);
        objectPrafabList.Add(krolik);
        objectPrafabList.Add(shot);
    }
}

// ������ ���� �� ���������