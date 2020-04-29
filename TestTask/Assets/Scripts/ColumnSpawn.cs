using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;
    private GameObject oldPrefab;
    void Start()
    {
        StartCoroutine(SpawnColumn());
    }

    private IEnumerator SpawnColumn()
    {

        for (; ; )
        {
            yield return new WaitForSeconds(1);
            Vector2 position = new Vector2(10, Random.Range(-1.7F,1.7F));
            oldPrefab = Instantiate(prefab, position, Quaternion.identity);
            Destroy(oldPrefab, 20);
        }
    }
}
