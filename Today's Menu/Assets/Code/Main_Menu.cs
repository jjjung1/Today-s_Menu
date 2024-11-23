using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main_Menu : MonoBehaviour
{
    public Image icon;
    public Sprite Null;

    public GameObject Popup;

    //public DeleteAll deleteManager;

    void Start()
    {
        icon.sprite = Null;
        Popup.SetActive(false);

        // Ãß°¡
/*        if (deleteManager != null)
        {
            deleteManager.mainIngredientIcon = icon;
        }*/
    }

    public void OnClicked()
    {
        Popup.SetActive(true);
    }

    public string GetCondition()
    {
        return icon.sprite.name;
    }
}