using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement; // �� ������ ���� �ʿ��� ���ӽ����̽�

public class RedCircle : MonoBehaviour
{
    private Renderer circleRenderer;
    private bool isRed = false;

    void Start()
    {
        circleRenderer = GetComponent<Renderer>();
        circleRenderer.material.color = Color.white;
        StartCoroutine(ChangeColorAndDestroy());
    }

    private IEnumerator ChangeColorAndDestroy()
    {
        yield return new WaitForSeconds(1f);
        circleRenderer.material.color = Color.red;
        isRed = true;
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isRed && other.CompareTag("Player"))
        {
            GameOver();
        }
    }

    private void GameOver()
    {
        Debug.Log("Player hit the red circle! Game Over.");
        SceneManager.LoadScene("TitleScene"); // Ÿ��Ʋ ������ �̵�
    }
}
