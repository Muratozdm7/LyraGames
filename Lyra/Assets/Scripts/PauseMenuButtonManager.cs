using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuButtonManager : MonoBehaviour
{
    public GameObject pausePanel; // Pause panel referans�

    public void ResumeGame()
    {
        Time.timeScale = 1f; // Oyun zaman�n� ger�ek zamanl� yap
        pausePanel.SetActive(false); // Paneli kapat
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Aktif sahneyi yeniden y�kle
        Time.timeScale = 1f; // Oyun zaman�n� ger�ek zamanl� yap
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu"); // MainMenu sahnesine ge�i� yap
        Time.timeScale = 1f; // Oyun zaman�n� ger�ek zamanl� yap
    }
}
