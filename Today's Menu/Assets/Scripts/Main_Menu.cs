using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main_Menu : MonoBehaviour
{
    public Image icon;

    public Sprite Null;

    public GameObject Popup;

    void Start()
    {
        icon.sprite = Null;
        Popup.SetActive(false);
    }

    public void OnClicked()
    {
        Popup.SetActive(true);
    }
}
