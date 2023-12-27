using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    private UnityEngine.Rendering.Universal.Light2D lightComponent; // Light yerine Light2D kullan�yoruz
    public float blinkInterval = 0.5f; // Yan�p s�nme aral��� (saniye)

    void Start()
    {
        // Light2D bile�enini al
        lightComponent = GetComponent<UnityEngine.Rendering.Universal.Light2D>();

        // I����n yan�p s�nme i�lemini ba�lat
        InvokeRepeating("Blink", 0, blinkInterval);
    }

    void Blink()
    {
        // I����n durumunu tersine �evir (yan�yor ise s�n, s�n�yor ise yan)
        lightComponent.enabled = !lightComponent.enabled;
    }
}
