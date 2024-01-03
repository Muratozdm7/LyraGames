using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("StoryboardScene"); // Level1 sahnesini y�kle
    }

    public void ExitGame()
    {
        // Oyunu kapat
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false; // E�er Unity Edit�rde �al���yorsa oyunu durdur
        #else
            Application.Quit(); // Oyun derlenmi� bir �ekilde �al���yorsa uygulamay� kapat
        #endif
    }
}
