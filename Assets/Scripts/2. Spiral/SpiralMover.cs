using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiralMover : MonoBehaviour
{
    private Vector2 polarPoint = new Vector2(0 /*radius*/, 0 /*theta*/);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Increment radius
        polarPoint.x += Time.deltaTime / 4;

        // Increment theta
        polarPoint.y += Time.deltaTime;

        // Convert to cartesian
        Vector2 cartesianPoint = polarPoint.FromPolarToCartesian();
        
        // Draw cartesian point
        cartesianPoint.Draw(Color.yellow);

        // Update this transform position
        transform.position = cartesianPoint;
    }
}
