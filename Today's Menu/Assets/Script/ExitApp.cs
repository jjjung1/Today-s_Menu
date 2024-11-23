using UnityEngine;

public class ExitApp : MonoBehaviour
{
    public void ExitGame()
    {
        Debug.Log("게임 종료");
        Application.Quit(); // 앱 종료
    }
}
