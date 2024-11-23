using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropZone : MonoBehaviour
{
    public string dropZoneName;
    public Image foodImage; //resultCanvas의 그 데이터
    public Text foodNameText; //resultCanvas의 그 데이터

    //요리 종류 쭉..
    public Sprite OmuriceImg;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Draggable"))
        {
            SetActive externalCode = FindObjectOfType<SetActive>();

            if (externalCode != null)
            {
                string objectName = other.gameObject.name;
                bool handled = false;

                if (dropZoneName == "rice")
                {
                    handled = HandleDropZoneRice(objectName);
                }
                else if (dropZoneName == "bread")
                {
                    handled = HandleDropZoneBread(objectName);
                }
                else if (dropZoneName == "noodle")
                {
                    handled = HandleDropZoneNoodle(objectName);
                }

                if (handled)
                {
                    externalCode.OnOffCanvas();
                }
            }
            else
            {
                Debug.LogWarning("ExternalCode 클래스가 씬에 없음");
            }
        }
    }

    private bool HandleDropZoneRice(string objectName)
    {
        switch (objectName)
        {
            case "meat":
                SetFoodInfo(OmuriceImg, "오므라이스"); 
                break;
            default:
                break;
        }

        return true;
    }

    private bool HandleDropZoneBread(string objectName)
    {
        switch (objectName)
        {
            case "meat":
                SetFoodInfo(OmuriceImg, "오므라이스");
                break;
            default:
                break;
        }

        return true;
    }

    private bool HandleDropZoneNoodle(string objectName)
    {
        switch (objectName)
        {
            case "meat":
                SetFoodInfo(OmuriceImg, "오므라이스"); 
                break;
            default:
                break;
        }

        return true;
    }

    private void SetFoodInfo(Sprite newSprite, string newText)
    {
        if (foodImage != null)
        {
            foodImage.sprite = newSprite;
            foodNameText.text = newText;
        }
        else
        {
            Debug.LogError("FoodImage가 설정되지 않았습니다.");
        }
    }
}


