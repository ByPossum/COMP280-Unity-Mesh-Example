using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//We need a mesh filter for this example
[RequireComponent(typeof(MeshFilter))]
public class GenerateGeometry : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Create a new Mesh
        Mesh mesh = new Mesh();
        mesh.name = "GeneratedMesh";
        Material shaderMat = GetComponent<Material>();

        //Grab the mesh filter and assign the newly created mesh
        GetComponent<MeshFilter>().mesh = mesh;

        //Create vertices, we must have these
        Vector3[] vertices =
        {
            new Vector3(0.0f, 0.0f, 0.0f),      // Origin 0
            new Vector3(0.0f, 1.0f, 0.0f),      // 1
            new Vector3(1.0f, 0.0f, 0.0f),      // 2
            new Vector3(1.0f, 1.0f, 0.0f),      // 3
            new Vector3(1.0f, 0.0f, 1.0f),      // 4
            new Vector3(1.0f, 1.0f, 1.0f),      // 5
            new Vector3(0.0f, 1.0f, 1.0f),      // 6
            new Vector3(0.0f, 0.0f, 1.0f)       // 7
        };

        //Normals and other elements are options but will be required
        //for lighting and texturing to work 
        Vector3[] normals =
        {
            new Vector3(0.0f,0.0f,-1.0f),       // 0 Norm
            new Vector3(0.0f,0.0f,-1.0f),       // 1 Norm
            new Vector3(0.0f,0.0f,-1.0f),       // 2 Norm
            new Vector3(0.0f,0.0f,-1.0f),       // 3 Norm
            new Vector3(1.0f, 0.0f, 0.0f),      // 4 Norm
            new Vector3(1.0f, 0.0f, 0.0f),      // 5 Norm
            new Vector3(0.0f, 1.0f, 0.0f),      // 6 Norm
            new Vector3(0.0f, -1.0f, 0.0f)      // 7 Norm
        };

        //Indices, called triangles in Unity, these are indices into the Vertex array above
        int[] triangles = 
        {
            // Front
            0, 1, 2, // Front face bottom
            1, 3, 2, // Front face top
            // Right
            3, 4, 2, // Right face bottom
            3, 5, 4, // Right face top
            // Top
            1, 5, 3,
            1, 6, 5,
            // Left
            0, 7, 1,
            7, 6, 1,
            // Back
            7, 4, 6,
            4, 5, 6,
            // Bottom
            0, 2, 7,
            7, 2, 4
        };

        //Assign all the values in the mesh
        mesh.vertices = vertices;
        mesh.normals = normals;
        mesh.triangles = triangles;
        
    }
}
