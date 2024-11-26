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

        int topCropHeight = Mathf.RoundToInt(screenHeight * 0.1f); //���� ũ�� ����
        int bottomCropHeight = Mathf.RoundToInt(screenHeight * 0.22f); //�Ʒ��� ũ�� ����
        int croppedHeight = screenHeight - (topCropHeight + bottomCropHeight);

        Texture2D croppedTexture = new Texture2D(screenWidth, croppedHeight, TextureFormat.RGB24, false);
        Color[] pixels = fullTexture.GetPixels(0, bottomCropHeight, screenWidth, croppedHeight);
        croppedTexture.SetPixels(pixels);
        croppedTexture.Apply();

        filePath = Path.Combine(Application.temporaryCachePath, "CookedMenu.png");
        File.WriteAllBytes(filePath, croppedTexture.EncodeToPNG());
        Debug.Log($"�̹��� ���� ���: {filePath}");

        // SNS ����
        new NativeShare()
            .AddFile(filePath)
            //.SetSubject("����")
            //.SetText("����")
            .SetUrl("https://github.com/jjjung1/Today-s_Menu")
            .SetCallback((result, target) => {
                 Debug.Log("���� ���: " + result + ", ���� ���: " + target);
             })
             .Share();

        Destroy(fullTexture);
        Destroy(croppedTexture);
    }
}
