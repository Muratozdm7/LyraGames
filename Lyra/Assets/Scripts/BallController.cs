using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float hizlanmaKuvveti = 100f;

    public AudioSource audioSound;
    bool _death = false;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (_death)
        {
            rb.velocity = Vector2.zero;
            return;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.gravityScale *= -1;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }



    void Death()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Engel1"))
        {
            audioSound.Play();
            _death = true;
            Invoke("Death", 3f);
        }
        /*if (other.gameObject.CompareTag("Finish"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        */
        // Tetikleyici alana (h�zlanma noktas�) girdi�inde kuvvet uygula
        if (other.CompareTag("Boost"))
        {
            rb.AddForce(new Vector2(hizlanmaKuvveti, 0), ForceMode2D.Force);
        }
    }
}
