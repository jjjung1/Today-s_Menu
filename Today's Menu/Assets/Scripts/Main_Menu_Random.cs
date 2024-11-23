using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main_Menu_Random : MonoBehaviour
{
    public Image icon;
    public Main_Menu Main_Menu;
    public Sprite Rice;
    public Sprite Noodle;
    public Sprite Bread;

    public void OnClicked()
    {
        int randomNumber = Random.Range(1, 4);
        switch (randomNumber) {
            case 1: icon.sprite = Rice; break;
            case 2: icon.sprite = Noodle; break;
            case 3: icon.sprite = Bread; break;
        }
        this.transform.parent.gameObject.SetActive(false);
    }
}
