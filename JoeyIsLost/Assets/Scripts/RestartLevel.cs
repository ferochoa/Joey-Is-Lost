//UM Games 2016
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

//OPCIONAL: Cambiar para que en vez de reiniciar el juego solo reinicie la pos de la pelota (Se quiere mantener la musica).
public class RestartLevel : MonoBehaviour
 
{
    public void restart()
    {
                Time.timeScale = 1;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
}
