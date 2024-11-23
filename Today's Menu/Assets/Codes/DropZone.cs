using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropZone : MonoBehaviour
{
    public string dropZoneName;
    public Image foodImage; //resultCanvas�� �� ������
    public Text foodNameText; //resultCanvas�� �� ������

    //�丮 ���� ��..
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
                Debug.LogWarning("ExternalCode Ŭ������ ���� ����");
            }
        }
    }

    private bool HandleDropZoneRice(string objectName)
    {
        switch (objectName)
        {
            case "meat":
                SetFoodInfo(OmuriceImg, "���Ƕ��̽�"); 
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
                SetFoodInfo(OmuriceImg, "���Ƕ��̽�");
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
                SetFoodInfo(OmuriceImg, "���Ƕ��̽�"); 
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
            Debug.LogError("FoodImage�� �������� �ʾҽ��ϴ�.");
        }
    }
}


