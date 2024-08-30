
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float rotationSpeed = 100f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
