using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionChecker : MonoBehaviour
{
    public BoundingBoxCalculator box1;
    public BoundingBoxCalculator box2;
    public GridGenerator grid;

    void Update()
    {
        if (box1.bounds.Intersects(box2.bounds))
        {
            CheckGridPointsCollision();
        }
    }

    void CheckGridPointsCollision()
    {
        foreach (Vector3 point in grid.gridPoints)
        {
            if (box1.bounds.Contains(point) && box2.bounds.Contains(point))
            {
                Debug.Log("Colisión detectada en el punto: " + point);
                return;
            }
        }
        Debug.Log("No hay colisión en los puntos de la grilla.");
    }
}