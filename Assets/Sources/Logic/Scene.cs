using UnityEngine.SceneManagement;

namespace Asteroids.Logic
{
    public class Scene
    {
        public void ReloadScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}