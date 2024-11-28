using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropZone : MonoBehaviour
{
    public Image foodImage; //resultCanvas의 그 데이터
    public Text foodNameText; //resultCanvas의 그 데이터

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

    //밥 or 빵 or 면 이름 가져오기
    public Main_Menu mainMenu;
    public string dropZoneName;

    System.Random random = new System.Random();

    void Update() //성능 하락 주의
    {
        if (mainMenu != null)
            if (mainMenu != null) 
            {
                dropZoneName = mainMenu.GetCondition();
            }
            else
            {
                Debug.LogWarning("Main_Menu 할당 오류");
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
                Debug.LogWarning("ExternalCode 클래스가 씬에 없음");
            }
        }
    }

    private bool HandleDropZoneRice(string objectName)
    {
        if (objectName.Contains("Water"))
        {
            int randomResult = random.Next(0, 100);

            if (randomResult < 2) // 확률 2%
            {

                SetFoodInfo(Img1, "식혜");
            }
            else if (2 <= randomResult && randomResult < 51)
            {
                SetFoodInfo(Img2, "죽");
            }
            else
            {
                SetFoodInfo(Img3, "떡국");
            }
        }
        else if (objectName.Contains("Egg"))
        {
            SetFoodInfo(Img4, "오므라이스");
        }
        else if (objectName.Contains("Fruits"))
        {
            int randomResult = random.Next(0, 100);

            if (randomResult < 50)
            {
                SetFoodInfo(Img5, "비빔밥");
            } else
            {
                SetFoodInfo(Img6, "파전");
            }
        }
        else if (objectName.Contains("Meat"))
        {
            SetFoodInfo(Img7, "수육 정식");
        }

        return true;
    }

    private bool HandleDropZoneBread(string objectName)
    {
        if (objectName.Contains("Water"))
        {
            SetFoodInfo(Img8, "눈물 젖은 빵");
        }
        else if (objectName.Contains("Egg"))
        {
            SetFoodInfo(Img9, "계란빵");
        }
        else if (objectName.Contains("Fruits"))
        {
            SetFoodInfo(Img10, "만두");
        }
        else if (objectName.Contains("Meat"))
        {
            SetFoodInfo(Img11, "햄버거");
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
                SetFoodInfo(Img12, "잔치국수");
            }
            else
            {
                SetFoodInfo(Img13, "칼국수");
            }
        }
        else if (objectName.Contains("Egg"))
        {
            SetFoodInfo(Img14, "팟타이");
        }
        else if (objectName.Contains("Fruits"))
        {
            int randomResult = random.Next(0, 100);

            if (randomResult < 50)
            {
                SetFoodInfo(Img15, "샐러드파스타");
            }
            else
            {
                SetFoodInfo(Img16, "쌀국수");
            }
        }
        else if (objectName.Contains("Meat"))
        {
            SetFoodInfo(Img17, "고기국수");
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


