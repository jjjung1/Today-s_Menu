using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private Vector3 offset;
    private Camera cam;
    private void Start()
    {
        cam = Camera.main; 
    }

    private void OnMouseDown()
    {
        offset = transform.position - GetMousePosition();
    }

    private void OnMouseDrag()
    {
        transform.position = GetMousePosition() + offset;
    }

    private Vector3 GetMousePosition()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 0; 
        return cam.ScreenToWorldPoint(mousePos);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log($"{gameObject.name}�� {collision.gameObject.name}�� �浹�߽��ϴ�!");
        ExecuteSpecificCode(collision.gameObject);
    }

    private void ExecuteSpecificCode(GameObject otherObject)
    {
        var targetScript = otherObject.GetComponent<SortingRule>();
        if (targetScript != null)
        {
            targetScript.RaiseSortingOrder(1);
        }
    }
}
