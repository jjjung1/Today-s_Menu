using UnityEngine;

public class DeleteIngredients : MonoBehaviour
{
    public GameObject ingredientsGroup; // 재료 그룹을 참조

    // 모든 재료 삭제 함수
    public void DeleteAllIngredients()
    {
        // IngredientsGroup 아래의 모든 자식을 삭제
        foreach (Transform child in ingredientsGroup.transform)
        {
            Destroy(child.gameObject); // 재료 UI 삭제
        }

        Debug.Log("모든 재료가 삭제되었습니다.");
    }
}
