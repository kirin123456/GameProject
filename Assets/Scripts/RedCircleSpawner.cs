using UnityEngine;

public class RedCircleSpawner : MonoBehaviour
{
    public GameObject redCirclePrefab;
    public float spawnInterval = 5f;
    public Vector3 spawnAreaMin; // 스테이지의 최소 좌표
    public Vector3 spawnAreaMax; // 스테이지의 최대 좌표

    private void Start()
    {
        InvokeRepeating("SpawnRedCircle", spawnInterval, spawnInterval);
    }

    private void SpawnRedCircle()
    {
        Vector3 spawnPosition = GetRandomPosition();
        Quaternion spawnRotation = Quaternion.Euler(90, 0, 0); // Z 축을 기준으로 평평하게 회전
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
