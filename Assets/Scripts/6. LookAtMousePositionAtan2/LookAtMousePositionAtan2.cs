using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMousePositionAtan2 : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Vector4 worldMousePosition = GetWorldMousePosition();
        float radians = Mathf.Atan2(worldMousePosition.y, worldMousePosition.x) - Mathf.PI / 2;
        RotateZ(radians);
    }

    private Vector4 GetWorldMousePosition()
    {
        Camera camera = Camera.main;
        Vector3 screenPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, camera.nearClipPlane);
        Vector4 worldPos = Camera.main.ScreenToWorldPoint(screenPos);
        return worldPos;
    }

    private void RotateZ(float radians)
    {
        transform.rotation = Quaternion.Euler(0.0f, 0.0f, radians * Mathf.Rad2Deg);
    }
}
