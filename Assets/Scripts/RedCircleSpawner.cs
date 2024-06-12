using UnityEngine;

public class RedCircleSpawner : MonoBehaviour
{
    public GameObject redCirclePrefab;
    public float spawnInterval = 5f;
    public Vector3 spawnAreaMin; // ���������� �ּ� ��ǥ
    public Vector3 spawnAreaMax; // ���������� �ִ� ��ǥ

    private void Start()
    {
        InvokeRepeating("SpawnRedCircle", spawnInterval, spawnInterval);
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
