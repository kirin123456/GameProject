using UnityEngine;
using System.Collections;

public class SphereSpawner : MonoBehaviour
{
    public GameObject spherePrefab;
    public float spawnInterval = 10f;
    public Vector3 spawnAreaMin; // ���������� �ּ� ��ǥ
    public Vector3 spawnAreaMax; // ���������� �ִ� ��ǥ

    void Start()
    {
        StartCoroutine(SpawnSphere());
    }

    IEnumerator SpawnSphere()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);
            Instantiate(spherePrefab, GetRandomPosition(), Quaternion.identity);
        }
    }

    Vector3 GetRandomPosition()
    {
        float x = Random.Range(spawnAreaMin.x, spawnAreaMax.x);
        float y = Random.Range(spawnAreaMin.y, spawnAreaMax.y);
        float z = Random.Range(spawnAreaMin.z, spawnAreaMax.z);
        return new Vector3(x, y, z);
    }
}
