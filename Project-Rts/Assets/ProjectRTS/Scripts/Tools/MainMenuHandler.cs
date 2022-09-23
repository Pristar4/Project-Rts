using UnityEngine;
using UnityEngine.SceneManagement;
namespace ProjectRTS.Scripts.Tools {
    public class MainMenuHandler : MonoBehaviour
    {

        public void StartGame()
        {
            SceneManager.LoadScene($"GameScene");
        }
        public void QuitGame()
        {
            if (Application.isEditor)
            {
                UnityEditor.EditorApplication.isPlaying = false;
            }
            else
            {
                Application.Quit();
            }

        }
    }
}
