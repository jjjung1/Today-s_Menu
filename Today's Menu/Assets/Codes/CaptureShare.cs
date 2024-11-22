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
        Debug.Log($"�̹��� ���� ���: {filePath}");

        // SNS ����
        new NativeShare()
            .AddFile(filePath)
            //.SetSubject("����")
            //.SetText("����")
            //.SetUrl("https://�� �ּ�")
            .SetCallback((result, target) => {
                 Debug.Log("���� ���: " + result + ", ���� ���: " + target);
             })
             .Share();

        Destroy(texture);
    }
}
