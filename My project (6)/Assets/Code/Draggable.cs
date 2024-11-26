using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{
    private bool isDragging = false; 
    private Vector3 offset; 
    private Camera mainCamera;

    private void Start()
    {
        mainCamera = Camera.main; 
    }

    private void OnMouseDown()
    {
        isDragging = true;

        Vector3 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        offset = transform.position - new Vector3(mousePosition.x, mousePosition.y, 0);
    }

    private void OnMouseDrag()
    {
        if (isDragging)
        {
            Vector3 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(mousePosition.x, mousePosition.y, 0) + offset;
        }
    }

    private void OnMouseUp()
    {
        // �巡�� ����
        isDragging = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //���콺�÷����� Ȯ���߰�, �� �ڵ忡�� �� �Ѿ�� �ڵ��߰�
        if (other.CompareTag("DropZone"))
        {
            Destroy(gameObject);
        }
    }
}

