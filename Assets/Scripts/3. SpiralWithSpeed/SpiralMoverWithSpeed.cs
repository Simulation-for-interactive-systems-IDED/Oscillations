using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiralMoverWithSpeed : MonoBehaviour
{
    [Header("Polar point")]
    [SerializeField]
    private Vector2 polarPoint = new Vector2(0 /*radius*/, 0 /*theta*/);

    [Header("Angular speed")]
    [SerializeField]
    private float angularSpeed = 1; // rad/s

    [SerializeField]
    private float angularAcceleration = 0; // rad/s*s

    [Header("Radial speed")]
    [SerializeField]
    private float radialSpeed = 1; // m/s

    [SerializeField]
    private float radialAcceleration = 0; // m/s*s

    // Update is called once per frame
    void Update()
    {
        // Increment radius
        radialSpeed += radialAcceleration * Time.deltaTime;
        polarPoint.x += radialSpeed * Time.deltaTime;

        // Increment theta
        angularSpeed += angularAcceleration * Time.deltaTime;
        polarPoint.y += angularSpeed * Time.deltaTime;

        // Convert to cartesian
        Vector2 cartesianPoint = polarPoint.FromPolarToCartesian();

        // Draw cartesian point
        cartesianPoint.Draw(Color.yellow);

        // Update this transform position
        transform.position = cartesianPoint;
    }
}
