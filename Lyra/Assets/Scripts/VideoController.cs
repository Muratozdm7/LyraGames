using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoController : MonoBehaviour
{
    public RawImage rawImage;
    public VideoPlayer videoPlayer;

    void Start()
    {
        // Video hazýr olduðunda VideoPrepared fonksiyonunu çaðýr
        videoPlayer.prepareCompleted += VideoPrepared;
        // Videoyu hazýrla
        videoPlayer.Prepare();
    }

    void VideoPrepared(VideoPlayer vp)
    {
        // Video hazýr olduðunda ekranda göster
        rawImage.texture = vp.texture;
        vp.Play();

        // Video bittiðinde bir sonraki sahneye geçiþ yap
        StartCoroutine(WaitForVideoEnd());
    }

    IEnumerator WaitForVideoEnd()
    {
        while (videoPlayer.isPlaying)
        {
            yield return null;
        }

        // Video bitti, bir sonraki sahneye geç
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1); // "Level2" sahne ismini kendi sahnenizle deðiþtirin
    }
}
