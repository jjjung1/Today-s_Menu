using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gatcha : MonoBehaviour
{
    public Button spawnButton; // ���� ��ư
    public GameObject[] prefabsToSpawn; // ������ ����� Prefab �迭
    public BoxCollider2D area; // ���� ����

   // public DeleteAll deleteManager; // DeleteAll ��ũ��Ʈ ����

   // private List<GameObject> spawnedPrefabs = new List<GameObject>();

    void Start()
    {
        spawnButton.onClick.AddListener(SpawnRandomObject);
    }

    void SpawnRandomObject()
    {
        if (prefabsToSpawn.Length == 0 || area == null) return;

        List<GameObject> availablePrefabs = new List<GameObject>(prefabsToSpawn);
        //availablePrefabs.RemoveAll(prefab => spawnedPrefabs.Contains(prefab));

        if (availablePrefabs.Count == 0)
        {
            Debug.Log("��� �������� �̹� �����Ǿ����ϴ�!");
            return;
        }

        Vector3 spawnPos = GetRandomPosition();

        // ������ ����
        GameObject spawnedObject = Instantiate(availablePrefabs[Random.Range(0, availablePrefabs.Count)], spawnPos, Quaternion.identity);
        //spawnedPrefabs.Add(spawnedObject);

/*        // ������ ����Ḧ DeleteAll�� ����Ʈ�� �߰�
        if (deleteManager != null)
        {
            deleteManager.subIngredientObjects.Add(spawnedObject);
        }*/
    }

    private Vector2 GetRandomPosition()
    {
        Vector2 basePosition = (Vector2)area.transform.position + area.offset;
        Vector2 size = area.size;

        float posX = Random.Range(basePosition.x - size.x / 2f, basePosition.x + size.x / 2f);
        float posY = Random.Range(basePosition.y - size.y / 2f, basePosition.y + size.y / 2f);

        return new Vector2(posX, posY);
    }
}