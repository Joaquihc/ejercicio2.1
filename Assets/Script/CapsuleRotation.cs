using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleRotation : MonoBehaviour
{
    public float speed;
    [SerializeField]
    private Vector3 rotation;

    // Update is called once per frame
    void Update()
    {
        rotation = CapsuleMovement.ClampVector(rotation);

        transform.Rotate(rotation * (speed * Time.deltaTime));
    }

    public static Vector3 ClampVector(Vector3 target)
    {
        float clampedX = Mathf.Clamp(target.x, -1f, 1f);
        float clampedY = Mathf.Clamp(target.y, -1f, 1f);
        float clampedZ = Mathf.Clamp(target.z, -1f, 1f);
       
        Vector3 result = new Vector3(clampedX, clampedY, clampedZ);

        return result;
    }
}
