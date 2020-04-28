using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControlller : MonoBehaviour
{
    [SerializeField]
    private float speed = 3.0F;

    private Transform target;

    private void Awake()
    {
        if (!target) target = FindObjectOfType<Charecter>().transform;
    }


    void Update()
    {
        Vector3 position = target.position;
        position.z = -10.0F;
        transform.position = Vector3.Lerp(transform.position, position, speed * Time.deltaTime)
    }
}
