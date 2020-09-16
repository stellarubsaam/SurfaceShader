using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject leftShoulder;
    public GameObject rightShoulder;
    public GameObject leftLeg;
    public GameObject rightLeg;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Fruit")
        {
            Vector3 scale = new Vector3(0.1f, 0, 0.1f);
            leftLeg.transform.localScale += scale;
            rightLeg.transform.localScale += scale;
            leftShoulder.transform.localScale += scale;
            rightShoulder.transform.localScale += scale;
            Destroy(other.gameObject);
        }
    }
}
