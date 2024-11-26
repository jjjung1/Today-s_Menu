using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CaptureShare : MonoBehaviour
{
    private string filePath;

    public void CaptureAndShareImage()
    {
        StartCoroutine(ImageControl());
    }

    private IEnumerator ImageControl()
    {
        yield return new WaitForEndOfFrame();

        int screenWidth = Screen.width;
        int screenHeight = Screen.height;
        Texture2D fullTexture = new Texture2D(screenWidth, screenHeight, TextureFormat.RGB24, false);
        fullTexture.ReadPixels(new Rect(0, 0, screenWidth, screenHeight), 0, 0);
        fullTexture.Apply();

        int topCropHeight = Mathf.RoundToInt(screenHeight * 0.1f); //위쪽 크롭 비율
        int bottomCropHeight = Mathf.RoundToInt(screenHeight * 0.22f); //아래쪽 크롭 비율
        int croppedHeight = screenHeight - (topCropHeight + bottomCropHeight);

        Texture2D croppedTexture = new Texture2D(screenWidth, croppedHeight, TextureFormat.RGB24, false);
        Color[] pixels = fullTexture.GetPixels(0, bottomCropHeight, screenWidth, croppedHeight);
        croppedTexture.SetPixels(pixels);
        croppedTexture.Apply();

        filePath = Path.Combine(Application.temporaryCachePath, "CookedMenu.png");
        File.WriteAllBytes(filePath, croppedTexture.EncodeToPNG());
        Debug.Log($"이미지 저장 경로: {filePath}");

        // SNS 공유
        new NativeShare()
            .AddFile(filePath)
            //.SetSubject("제목")
            //.SetText("내용")
            .SetUrl("https://github.com/jjjung1/Today-s_Menu")
            .SetCallback((result, target) => {
                 Debug.Log("공유 결과: " + result + ", 공유 대상: " + target);
             })
             .Share();

        Destroy(fullTexture);
        Destroy(croppedTexture);
    }
}
