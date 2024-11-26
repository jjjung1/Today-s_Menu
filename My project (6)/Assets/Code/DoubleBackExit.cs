using UnityEngine;

public class DoubleBackExit : MonoBehaviour
{
    private float lastBackPressTime = 0f; // 마지막으로 뒤로가기 버튼을 누른 시간
    private const float backPressThreshold = 0.5f; // 두 번 눌러야 하는 시간 간격 (초)

    void Update()
    {
        // 뒤로가기 버튼 감지
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // 이전 버튼 누름과의 시간 간격 계산
            if (Time.time - lastBackPressTime < backPressThreshold)
            {
                Debug.Log("게임 종료");
                Application.Quit(); // 앱 종료
            }
            else
            {
                Debug.Log("다시 뒤로가기를 누르면 종료됩니다.");
                lastBackPressTime = Time.time; // 현재 시간 저장
            }
        }
    }
}
