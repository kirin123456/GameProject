using System.Collections;
using UnityEngine;

public class RedCircleSpawner : MonoBehaviour
{
    public GameObject redCirclePrefab;
    public float initialSpawnInterval = 5f;
    public float minSpawnInterval = 1f;
    public float intervalDecreaseRate = 0.1f;
    public Vector3 spawnAreaMin; // ���������� �ּ� ��ǥ
    public Vector3 spawnAreaMax; // ���������� �ִ� ��ǥ

    private float currentSpawnInterval;

    private void Start()
    {
        currentSpawnInterval = initialSpawnInterval;
        StartCoroutine(SpawnRedCircleRoutine());
    }

    private IEnumerator SpawnRedCircleRoutine()
    {
        while (true)
        {
            SpawnRedCircle();
            yield return new WaitForSeconds(currentSpawnInterval);
            // ���� �� ���� ������ ���Դϴ�.
            currentSpawnInterval = Mathf.Max(minSpawnInterval, currentSpawnInterval - intervalDecreaseRate);
        }
    }

    private void SpawnRedCircle()
    {
        Vector3 spawnPosition = GetRandomPosition();
        Quaternion spawnRotation = Quaternion.Euler(90, 0, 0); // Z ���� �������� �����ϰ� ȸ��
        Instantiate(redCirclePrefab, spawnPosition, spawnRotation);
    }

    private Vector3 GetRandomPosition()
    {
        float x = Random.Range(spawnAreaMin.x, spawnAreaMax.x);
        float y = Random.Range(spawnAreaMin.y, spawnAreaMax.y);
        float z = Random.Range(spawnAreaMin.z, spawnAreaMax.z);
        return new Vector3(x, y, z);
    }
}
