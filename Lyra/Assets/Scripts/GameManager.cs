using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text spaceYazi; // Canvas üzerindeki Text objesini baðlamak için

    public GameObject pausePanel; // Unity Editor'da panelin referansýný ata
    private bool isPaused = false; // Oyun durumu kontrolü için flag

    bool oyunDurdu = false;


    /*void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player2")) // Eðer tetikleyiciye "Player" objesi dokunursa
        {
            OyunuDurdur();
        }
    }
    */

    void Update()
    {
        if (oyunDurdu && Input.GetKeyDown(KeyCode.Space)) // "Space" tuþuna basýldýðýnda
        {
            OyunuDevamEttir();
        }

        if (Input.GetKeyDown(KeyCode.Escape)) // Eðer ESC tuþuna basýldýysa
        {
            isPaused = !isPaused; // Oyun durumunu tersine çevir

            if (isPaused)
            {
                PauseGame();
            }
            else
            {
                ResumeGame();
            }
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0f; // Oyun zamanýný durdur
        pausePanel.SetActive(true); // Paneli aktif hale getir
    }

    void ResumeGame()
    {
        Time.timeScale = 1f; // Oyun zamanýný gerçek zamanlý yap
        pausePanel.SetActive(false); // Paneli pasif hale getir
    }

    void OyunuDevamEttir()
    {
        Time.timeScale = 1f; // Oyun zamanýný tekrar baþlat
        oyunDurdu = false;
    }


    void OyunuDurdur()
    {
        Time.timeScale = 0f; // Oyun zamanýný durdur
        oyunDurdu = true;
    }
}
