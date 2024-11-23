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
    public Sprite Img2;
    public Sprite Img3;
    public Sprite Img4;
    public Sprite Img5;
    public Sprite Img6;
    public Sprite Img7;
    public Sprite Img8;

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
        if (objectName.Contains("Egg"))
        {
            SetFoodInfo(OmuriceImg, "���Ƕ��̽�");
        }
        else if (objectName.Contains("Fruits"))
        {
            SetFoodInfo(Img2, "�����");
        }
        else if (objectName.Contains("Meat"))
        {
            SetFoodInfo(OmuriceImg, "��������");
        }
        else if (objectName.Contains("Water"))
        {
            SetFoodInfo(Img8, "��");
        }

        return true;
    }

    private bool HandleDropZoneBread(string objectName)
    {
        if (objectName.Contains("Egg"))
        {
            SetFoodInfo(Img7, "�����");
        }
        else if (objectName.Contains("Fruits"))
        {
            SetFoodInfo(Img5, "����");
        }
        else if (objectName.Contains("Meat"))
        {
            SetFoodInfo(OmuriceImg, "�ܹ���");
        }
        else if (objectName.Contains("Water"))
        {
            SetFoodInfo(OmuriceImg, "���� ���� ��");
        }

        return true;
    }

    private bool HandleDropZoneNoodle(string objectName)
    {
        if (objectName.Contains("Egg"))
        {
            SetFoodInfo(Img4, "��Ÿ��");
        }
        else if (objectName.Contains("Fruits"))
        {
            SetFoodInfo(Img3, "�ұ���");
        }
        else if (objectName.Contains("Meat"))
        {
            SetFoodInfo(Img3, "��ⱹ��");
        }
        else if (objectName.Contains("Water"))
        {
            SetFoodInfo(Img3, "��ġ����");
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


