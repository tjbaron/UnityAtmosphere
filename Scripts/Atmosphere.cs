using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Atmosphere : MonoBehaviour
{
    public Material material;
    public Transform lightSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (material && lightSource)
        {
            material.SetVector("LightDirection", (lightSource.position - transform.position).normalized);
        }
    }
}
