using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Main_Menu_Popup : MonoBehaviour
{
    public Image icon;
    public Sprite sprite;
    public Main_Menu mainMenu; //
    public void OnClicked()
    {
        if (sprite != null)
        {
            icon.sprite = sprite;
            mainMenu.SetSpriteName(sprite.name); //
        }
        this.transform.parent.gameObject.SetActive(false);
    }
}