using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VertexShader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MeshRenderer m = GetComponent<MeshRenderer>();
        m.material.SetFloat("movement", Time.realtimeSinceStartup);
    }
}
