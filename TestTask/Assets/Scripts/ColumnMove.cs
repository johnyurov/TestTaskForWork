using UnityEngine;

public class ColumnMove : MonoBehaviour
{
    private float speed = 0.1F;
    void Update()
    {
        transform.Translate(-speed,0,0);
    }
}
