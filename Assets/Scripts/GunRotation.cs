using System;
using UnityEngine;

public class GunRotation : MonoBehaviour
{
    [SerializeField] private Transform gunTransform;
    [SerializeField] private float rotationSpeed = 5f;
    [SerializeField] bool isRotatingClockwise = false;

    private void Awake()
    {
        gunTransform = GetComponent<Transform>();
    }

    void RotateGun()
    {
        switch (isRotatingClockwise)
        {
            case true:
                gunTransform.Rotate(Vector3.forward, rotationSpeed * 100 * Time.deltaTime);
                break;
            case false:
                gunTransform.Rotate(Vector3.forward, -rotationSpeed * 100 * Time.deltaTime);
                break;
            default:
                break;
        }
    }

    private void Update()
    {
        RotateGun();
    }
}
