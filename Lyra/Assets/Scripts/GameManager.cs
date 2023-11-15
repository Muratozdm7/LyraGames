using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text spaceYazi; // Canvas �zerindeki Text objesini ba�lamak i�in

    public GameObject pausePanel; // Unity Editor'da panelin referans�n� ata
    private bool isPaused = false; // Oyun durumu kontrol� i�in flag

    bool oyunDurdu = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // E�er tetikleyiciye "Player" objesi dokunursa
        {
            OyunuDurdur();
        }
    }

    void Update()
    {
        if (oyunDurdu && Input.GetKeyDown(KeyCode.Space)) // "Space" tu�una bas�ld���nda
        {
            OyunuDevamEttir();
        }

        if (Input.GetKeyDown(KeyCode.Escape)) // E�er ESC tu�una bas�ld�ysa
        {
            isPaused = !isPaused; // Oyun durumunu tersine �evir

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
        Time.timeScale = 0f; // Oyun zaman�n� durdur
        pausePanel.SetActive(true); // Paneli aktif hale getir
    }

    void ResumeGame()
    {
        Time.timeScale = 1f; // Oyun zaman�n� ger�ek zamanl� yap
        pausePanel.SetActive(false); // Paneli pasif hale getir
    }

    void OyunuDurdur()
    {
        Time.timeScale = 0f; // Oyun zaman�n� durdur
        oyunDurdu = true;

        // Text objesine metin yazma
        spaceYazi.text = "Space Tu�una Bas!"; // Text objesine istedi�iniz metni yaz�n

        // Metni g�r�n�r yap
        spaceYazi.enabled = true;
    }

    void OyunuDevamEttir()
    {
        Time.timeScale = 1f; // Oyun zaman�n� tekrar ba�lat
        oyunDurdu = false;

        // Metni gizle
        spaceYazi.enabled = false;
    }
}
