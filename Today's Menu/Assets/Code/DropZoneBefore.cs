using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropZoneBefore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Draggable"))
        {
            SetActive externalCode = FindObjectOfType<SetActive>();
            if (externalCode != null)
            {
                externalCode.OnOffCanvas();
            }
            else
            {
                Debug.LogWarning("ExternalCode 클래스가 씬에 없음");
            }
        }
    }
}
