using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleScaling : MonoBehaviour
{
    public float scaleUnits;
    [SerializeField]
    private Vector3 axes;

    // Update is called once per frame
    void Update()
    {
        axes = CapsuleMovement.ClampVector(axes);

        transform.localScale += axes * (scaleUnits * Time.deltaTime);
    }
}
