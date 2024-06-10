using UnityEngine;

public class ClearBulletsSphere : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player collided with sphere. Clearing all bullets.");
            ClearAllBullets();
            Destroy(gameObject); // ��ü�� �ı��մϴ�.
        }
    }

    void ClearAllBullets()
    {
        GameObject[] bullets = GameObject.FindGameObjectsWithTag("Bullet");
        foreach (GameObject bullet in bullets)
        {
            Destroy(bullet);
        }
    }
}
