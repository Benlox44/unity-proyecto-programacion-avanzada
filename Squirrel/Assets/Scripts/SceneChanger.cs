using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {
    [SerializeField] private string sceneName;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Player")) SceneManager.LoadScene(sceneName);
    }
}