using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawPolarPoint : MonoBehaviour
{
    [SerializeField]
    Vector2 m_polarPoint = new Vector2(1/*radius*/, 0/*theta*/);

    void Update()
    {
        Vector2 cartesianPoint = m_polarPoint.FromPolarToCartesian();
        cartesianPoint.Draw(Color.yellow);
    }
}
