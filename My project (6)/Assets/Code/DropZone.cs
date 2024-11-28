using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropZone : MonoBehaviour
{
    public Image foodImage; //resultCanvas�� �� ������
    public Text foodNameText; //resultCanvas�� �� ������

    public Sprite Img1;
    public Sprite Img2;
    public Sprite Img3;
    public Sprite Img4;
    public Sprite Img5;
    public Sprite Img6;
    public Sprite Img7;
    public Sprite Img8;
    public Sprite Img9;
    public Sprite Img10;
    public Sprite Img11;
    public Sprite Img12;
    public Sprite Img13;
    public Sprite Img14;
    public Sprite Img15;
    public Sprite Img16;
    public Sprite Img17;

    //�� or �� or �� �̸� ��������
    public Main_Menu mainMenu;
    public string dropZoneName;

    System.Random random = new System.Random();

    void Update() //���� �϶� ����
    {
        if (mainMenu != null)
            if (mainMenu != null) 
            {
                dropZoneName = mainMenu.GetCondition();
            }
            else
            {
                Debug.LogWarning("Main_Menu �Ҵ� ����");
            }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Draggable"))
        {
            SetActive externalCode = FindObjectOfType<SetActive>();

            if (externalCode != null)
            {
                string objectName = other.gameObject.name;
                bool handled = false;

                if (dropZoneName == "Rice")
                {
                    handled = HandleDropZoneRice(objectName);
                }
                else if (dropZoneName == "Bread")
                {
                    handled = HandleDropZoneBread(objectName);
                }
                else if (dropZoneName == "Noodle")
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
        if (objectName.Contains("Water"))
        {
            int randomResult = random.Next(0, 100);

            if (randomResult < 2) // Ȯ�� 2%
            {

                SetFoodInfo(Img1, "����");
            }
            else if (2 <= randomResult && randomResult < 51)
            {
                SetFoodInfo(Img2, "��");
            }
            else
            {
                SetFoodInfo(Img3, "����");
            }
        }
        else if (objectName.Contains("Egg"))
        {
            SetFoodInfo(Img4, "���Ƕ��̽�");
        }
        else if (objectName.Contains("Fruits"))
        {
            int randomResult = random.Next(0, 100);

            if (randomResult < 50)
            {
                SetFoodInfo(Img5, "�����");
            } else
            {
                SetFoodInfo(Img6, "����");
            }
        }
        else if (objectName.Contains("Meat"))
        {
            SetFoodInfo(Img7, "���� ����");
        }

        return true;
    }

    private bool HandleDropZoneBread(string objectName)
    {
        if (objectName.Contains("Water"))
        {
            SetFoodInfo(Img8, "���� ���� ��");
        }
        else if (objectName.Contains("Egg"))
        {
            SetFoodInfo(Img9, "�����");
        }
        else if (objectName.Contains("Fruits"))
        {
            SetFoodInfo(Img10, "����");
        }
        else if (objectName.Contains("Meat"))
        {
            SetFoodInfo(Img11, "�ܹ���");
        }

        return true;
    }

    private bool HandleDropZoneNoodle(string objectName)
    {
        if (objectName.Contains("Water"))
        {
            int randomResult = random.Next(0, 100);

            if (randomResult < 50) 
            {
                SetFoodInfo(Img12, "��ġ����");
            }
            else
            {
                SetFoodInfo(Img13, "Į����");
            }
        }
        else if (objectName.Contains("Egg"))
        {
            SetFoodInfo(Img14, "��Ÿ��");
        }
        else if (objectName.Contains("Fruits"))
        {
            int randomResult = random.Next(0, 100);

            if (randomResult < 50)
            {
                SetFoodInfo(Img15, "�������Ľ�Ÿ");
            }
            else
            {
                SetFoodInfo(Img16, "�ұ���");
            }
        }
        else if (objectName.Contains("Meat"))
        {
            SetFoodInfo(Img17, "��ⱹ��");
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


