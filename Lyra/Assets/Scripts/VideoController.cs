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
        // Video haz�r oldu�unda VideoPrepared fonksiyonunu �a��r
        videoPlayer.prepareCompleted += VideoPrepared;
        // Videoyu haz�rla
        videoPlayer.Prepare();
    }

    void VideoPrepared(VideoPlayer vp)
    {
        // Video haz�r oldu�unda ekranda g�ster
        rawImage.texture = vp.texture;
        vp.Play();

        // Video bitti�inde bir sonraki sahneye ge�i� yap
        StartCoroutine(WaitForVideoEnd());
    }

    IEnumerator WaitForVideoEnd()
    {
        while (videoPlayer.isPlaying)
        {
            yield return null;
        }

        // Video bitti, bir sonraki sahneye ge�
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1); // "Level2" sahne ismini kendi sahnenizle de�i�tirin
    }
}
