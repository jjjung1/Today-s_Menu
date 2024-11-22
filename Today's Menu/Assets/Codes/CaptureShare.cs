using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class CaptureShare : MonoBehaviour
{
    public Image targetImage;
    private string filePath;

    public void CaptureAndShareImage()
    {
        StartCoroutine(ImageControl());
    }

    private IEnumerator ImageControl()
    {
        yield return new WaitForEndOfFrame();

        RectTransform rectTransform = targetImage.GetComponent<RectTransform>();
        Canvas canvas = targetImage.GetComponentInParent<Canvas>();

        Button buttonToExclude = targetImage.transform.Find("Exit Button").GetComponent<Button>();
        if (buttonToExclude != null)
        {
            buttonToExclude.gameObject.SetActive(false);
        }

        Canvas.ForceUpdateCanvases();

        yield return new WaitForEndOfFrame();

        Vector2 localPos = rectTransform.localPosition;
        localPos.y += 18;

        Vector2 size = rectTransform.rect.size;
        float scaleFactor = canvas.scaleFactor; 

        float x = (localPos.x + canvas.pixelRect.width / 2) - (size.x / 2) * scaleFactor;
        float y = (localPos.y + canvas.pixelRect.height / 2) - (size.y / 2) * scaleFactor;
        float width = size.x * scaleFactor;
        float height = size.y * scaleFactor;

        Rect captureRect = new Rect(x, y, width, height);

        Texture2D texture = new Texture2D((int)captureRect.width, (int)captureRect.height, TextureFormat.RGB24, false);
        texture.ReadPixels(captureRect, 0, 0);
        texture.Apply();

        if (buttonToExclude != null)
        {
            buttonToExclude.gameObject.SetActive(true);
        }

        filePath = Path.Combine(Application.temporaryCachePath, "CookedMenu.png");
        File.WriteAllBytes(filePath, texture.EncodeToPNG());
        Debug.Log($"이미지 저장 경로: {filePath}");

        // SNS 공유
        new NativeShare()
            .AddFile(filePath)
            //.SetSubject("제목")
            //.SetText("내용")
            //.SetUrl("https://앱 주소")
            .SetCallback((result, target) => {
                 Debug.Log("공유 결과: " + result + ", 공유 대상: " + target);
             })
             .Share();

        Destroy(texture);
    }
}
