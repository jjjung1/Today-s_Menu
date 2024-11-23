using UnityEngine;
using UnityEngine.SceneManagement; // 씬 전환을 위한 네임스페이스

public class TouchToNextScene : MonoBehaviour
{
    void Update()
    {
        // 마우스 클릭 또는 터치 입력을 감지
        if (Input.GetMouseButtonDown(0)) // 0은 왼쪽 마우스 버튼 클릭 또는 터치
        {
            LoadNextScene();
        }
    }

    void LoadNextScene()
    {
        // 현재 씬의 인덱스를 가져와 다음 씬으로 이동
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1); // 다음 씬 로드
    }
}
