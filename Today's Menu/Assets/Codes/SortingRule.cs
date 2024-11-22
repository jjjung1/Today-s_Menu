using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortingRule : MonoBehaviour
{
    public Canvas[] canvases;

    public void RaiseSortingOrder(int index)
    {
        if (index >= 0 && index < canvases.Length)
        {
            int currentOrder = canvases[index].sortingOrder;
            canvases[index].sortingOrder = currentOrder + 10;
        }
        else
        {
            Debug.LogWarning("Canvas sorting 오류 - Canvas를 찾을 수 없음");
        }
    }

    public void LowerSortingOrder(int index)
    {
        if (index >= 0 && index < canvases.Length)
        {
            int currentOrder = canvases[index].sortingOrder;
            canvases[index].sortingOrder = currentOrder - 10;
        }
        else
        {
            Debug.LogWarning("Canvas sorting 오류 - Canvas를 찾을 수 없음");
        }
    }
}