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
        // 드래그 종료
        isDragging = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //마우스올렸을때 확인추가, 이 코드에서 씬 넘어가기 코드추가
        if (other.CompareTag("DropZone"))
        {
            Destroy(gameObject);
        }
    }
}

