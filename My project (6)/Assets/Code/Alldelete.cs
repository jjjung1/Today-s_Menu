using UnityEngine;
using UnityEngine.UI;

public class Alldelete : MonoBehaviour
{
    public Image icon;
    public Sprite Null;

    public void Onclicked()
    {
        icon.sprite = Null; 
        // "Draggable" �±׸� ���� ��� ���� ������Ʈ�� ã��
        GameObject[] draggableObjects = GameObject.FindGameObjectsWithTag("Draggable");

        // ã�� ��� ������Ʈ�� ����
        foreach (GameObject obj in draggableObjects)
        {
            Destroy(obj);
        }
    }
}
