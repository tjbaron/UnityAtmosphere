using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class PostAtmosphere : MonoBehaviour
{
    public Material material;
    public Material planetMaterial;
    public Transform planet;
    public Transform lightSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (material && planet && lightSource)
        {
            material.SetVector("Planet", planet.position);
            material.SetVector("LightDirection", (lightSource.position - planet.position).normalized);
        }
        if (planetMaterial && planet && lightSource)
        {
            planetMaterial.SetVector("LightDirection", (lightSource.position - planet.position).normalized);
        }
    }
}
