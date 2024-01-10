using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class HueEffect : MonoBehaviour
{
    [SerializeField] Volume _Volume;
    private ColorAdjustments _ColorAdjustments = null;




    void Start()
    {
        _Volume.profile.TryGet(out _ColorAdjustments);
    }

    void Update()
    {

        if (_ColorAdjustments == null)
        {
            Debug.LogError("Color Adjustments is null!");
            return;
        }

        //-180 to 180 is the range of hue shift
        float val = Mathf.PingPong(Time.time * 100, 180) - 180;
        _ColorAdjustments.hueShift.value = val;
    }
}
