using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuButtonManager : MonoBehaviour
{
    public GameObject pausePanel; // Pause panel referansý

    public void ResumeGame()
    {
        Time.timeScale = 1f; // Oyun zamanýný gerçek zamanlý yap
        pausePanel.SetActive(false); // Paneli kapat
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Aktif sahneyi yeniden yükle
        Time.timeScale = 1f; // Oyun zamanýný gerçek zamanlý yap
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu"); // MainMenu sahnesine geçiþ yap
        Time.timeScale = 1f; // Oyun zamanýný gerçek zamanlý yap
    }
}
