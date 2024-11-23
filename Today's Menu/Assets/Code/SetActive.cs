using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive : MonoBehaviour
{
    public GameObject canvasObject;

    public void OnOffCanvas()
    {
        if (canvasObject != null)
        { 
            canvasObject.SetActive(!canvasObject.activeSelf);
        }
        else
        {
            Debug.LogWarning("Canvas Object가 설정되지 않음");
        }
    }
}
