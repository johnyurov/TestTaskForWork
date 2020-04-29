using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnMove : MonoBehaviour
{
    
    private float speed = 0.05F;

    void Update()
    {
        transform.Translate(-speed,0,0);
        
    }
}
