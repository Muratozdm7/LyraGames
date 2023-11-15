using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform takipEdilecekNesne;
    public float takipHizi = 2.0f;
    public Vector3 offset;
    public float minX, maxX;

    void FixedUpdate()
    {
        float hedefX = Mathf.Clamp(takipEdilecekNesne.position.x + offset.x, minX, maxX);
        Vector3 hedefPozisyon = new Vector3(hedefX, transform.position.y, transform.position.z);
        Vector3 yumusakHedef = Vector3.Lerp(transform.position, hedefPozisyon, takipHizi * Time.deltaTime);
        transform.position = yumusakHedef;
    }
}
