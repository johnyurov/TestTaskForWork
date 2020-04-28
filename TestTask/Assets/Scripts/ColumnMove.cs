using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnMove : MonoBehaviour
{
    [SerializeField]
    private float speed = 2.0F;

    void Update()
    {
        transform.Translate(-speed,0,0);
    }
}
