using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gatcha : MonoBehaviour
{
    public Button spawnButton; // 생성 버튼
    public GameObject[] prefabsToSpawn; // 생성할 부재료 Prefab 배열
    public BoxCollider2D area; // 생성 영역

   // public DeleteAll deleteManager; // DeleteAll 스크립트 연결

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
            Debug.Log("모든 아이템이 이미 생성되었습니다!");
            return;
        }

        Vector3 spawnPos = GetRandomPosition();

        // 프리팹 생성
        GameObject spawnedObject = Instantiate(availablePrefabs[Random.Range(0, availablePrefabs.Count)], spawnPos, Quaternion.identity);
        //spawnedPrefabs.Add(spawnedObject);

/*        // 생성된 부재료를 DeleteAll의 리스트에 추가
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