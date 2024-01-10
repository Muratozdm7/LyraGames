using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPoint : MonoBehaviour
{
    public GameObject effectPrefab;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Time.timeScale = 0.3f;
            Instantiate(effectPrefab, transform);
            Invoke("nextLevel", 0.5f);
        }
    }

    void nextLevel()
    {
        Time.timeScale = 1f;
        SceneController.instance.NextLevel();
    }
    
}
