using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomGet : MonoBehaviour
{
    public Button spawnButton;
    public GameObject[] prefabsToSpawn;
    public BoxCollider2D area;

    void Start()
    {
        spawnButton.onClick.AddListener(SpawnRandomObject);
    }

    void SpawnRandomObject()
    {
        if (prefabsToSpawn.Length == 0 || area == null) return;

        Vector3 spawnPos = GetRandomPosition(); 

        int randomIndex = Random.Range(0, prefabsToSpawn.Length);
        GameObject selectedPrefab = prefabsToSpawn[randomIndex];
       // selectedPrefab.SetActive(true);
        GameObject Prefab_object = Instantiate(selectedPrefab, spawnPos, Quaternion.identity);
        Prefab_object.transform.SetParent(GameObject.Find("Canvas").transform);
        //Prefab_object.SetActive(true);
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
