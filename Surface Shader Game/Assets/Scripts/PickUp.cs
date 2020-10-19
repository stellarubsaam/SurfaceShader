using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Material targetMaterial;
    public Material targetMaterial2;
    public float scale;

    private void Start()
    {
        scale =1;
        targetMaterial.SetFloat("ExpandVector", scale);
        targetMaterial2.SetFloat("ExpandVector", scale);
    }
    private void Update()
    {
        Debug.Log(targetMaterial.GetFloat("ExpandVector"));
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Fruit")
        {
            scale += 0.1f;
            targetMaterial.SetFloat("ExpandVector", scale);
            targetMaterial2.SetFloat("ExpandVector", scale);
            
            Destroy(other.gameObject);
        }
    }
}
