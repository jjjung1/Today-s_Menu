using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeleteAll : MonoBehaviour
{
    public Image mainIngredientIcon; // 주재료 아이콘 (Main_Menu에서 참조)
    public List<GameObject> subIngredientObjects = new List<GameObject>(); // 부재료 리스트 (Gatcha에서 추가됨)

    // 삭제 버튼 클릭 시 호출
    public void OnDeleteAllClicked()
    {
        // 1. 주재료 초기화
        if (mainIngredientIcon != null)
        {
            mainIngredientIcon.sprite = null; // 주재료 아이콘 초기화
            Debug.Log("주재료가 초기화되었습니다.");
        }

        // 2. 부재료 오브젝트 삭제
        foreach (GameObject obj in subIngredientObjects)
        {
            if (obj != null) // 존재하는 경우 삭제
            {
                Destroy(obj);
            }
        }

        // 부재료 리스트 초기화
        subIngredientObjects.Clear();

        Debug.Log("부재료가 모두 삭제되었습니다!");
    }
}
