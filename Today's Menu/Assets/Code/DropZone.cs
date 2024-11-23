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
                Debug.LogWarning("ExternalCode 클래스가 씬에 없음");
            }
        }
    }

    private bool HandleDropZoneRice(string objectName)
    {
        if (objectName.Contains("Egg"))
        {
            SetFoodInfo(OmuriceImg, "오므라이스");
        }
        else if (objectName.Contains("Fruits"))
        {
            SetFoodInfo(Img2, "비빔밥");
        }
        else if (objectName.Contains("Meat"))
        {
            SetFoodInfo(OmuriceImg, "수육정식");
        }
        else if (objectName.Contains("Water"))
        {
            SetFoodInfo(Img8, "죽");
        }

        return true;
    }

    private bool HandleDropZoneBread(string objectName)
    {
        if (objectName.Contains("Egg"))
        {
            SetFoodInfo(Img7, "계란빵");
        }
        else if (objectName.Contains("Fruits"))
        {
            SetFoodInfo(Img5, "만두");
        }
        else if (objectName.Contains("Meat"))
        {
            SetFoodInfo(OmuriceImg, "햄버거");
        }
        else if (objectName.Contains("Water"))
        {
            SetFoodInfo(OmuriceImg, "눈물 젖은 빵");
        }

        return true;
    }

    private bool HandleDropZoneNoodle(string objectName)
    {
        if (objectName.Contains("Egg"))
        {
            SetFoodInfo(Img4, "팟타이");
        }
        else if (objectName.Contains("Fruits"))
        {
            SetFoodInfo(Img3, "쌀국수");
        }
        else if (objectName.Contains("Meat"))
        {
            SetFoodInfo(Img3, "고기국수");
        }
        else if (objectName.Contains("Water"))
        {
            SetFoodInfo(Img3, "잔치국수");
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


