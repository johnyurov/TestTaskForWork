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
            if (gameObject.tag == "Player")
                break;
            yield return new WaitForSeconds(2);
            Vector3 position = new Vector3(10.0F, Random.Range(-1.7F, 1.7F), 0);
            oldPrefab = Instantiate(prefab, position, Quaternion.identity);
            Destroy(oldPrefab, 15);
        }
    }
}
