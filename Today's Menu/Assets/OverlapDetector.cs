using UnityEngine;
using UnityEngine.SceneManagement;

public class OverlapDetector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ingredient"))
        {
            Debug.Log("재료 겹침 감지");
            SceneManager.LoadScene("NextScene"); // 다음 씬 이름 입력
        }
    }
}
