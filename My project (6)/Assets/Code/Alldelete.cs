using UnityEngine;
using UnityEngine.UI;

public class Alldelete : MonoBehaviour
{
    public Image icon;
    public Sprite Null;

    public void Onclicked()
    {
        icon.sprite = Null; 
        // "Draggable" 태그를 가진 모든 게임 오브젝트를 찾음
        GameObject[] draggableObjects = GameObject.FindGameObjectsWithTag("Draggable");

        // 찾은 모든 오브젝트를 삭제
        foreach (GameObject obj in draggableObjects)
        {
            Destroy(obj);
        }
    }
}
