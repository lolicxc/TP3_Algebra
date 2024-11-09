using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundingBoxCalculator : MonoBehaviour
{
    private MeshFilter meshFilter;
    private Mesh mesh;
    public Bounds bounds;

    void Start()
    {
        meshFilter = GetComponent<MeshFilter>();
        mesh = meshFilter.mesh;
    }

    void Update()
    {
        bounds = mesh.bounds;
        bounds.center = transform.position;
        bounds.extents = Vector3.Scale(bounds.extents, transform.localScale);
    }

    void OnDrawGizmos()
    {
        // Dibujar la bounding box en el editor
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(bounds.center, bounds.size);
    }
}