using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("StoryboardScene"); // Level1 sahnesini yükle
    }

    public void ExitGame()
    {
        // Oyunu kapat
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false; // Eðer Unity Editörde çalýþýyorsa oyunu durdur
        #else
            Application.Quit(); // Oyun derlenmiþ bir þekilde çalýþýyorsa uygulamayý kapat
        #endif
    }
}
