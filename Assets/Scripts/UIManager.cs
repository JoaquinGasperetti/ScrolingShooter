using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene("Juego"); 
    }

    public void Salir()
    {
        Application.Quit();
        Debug.Log("Saliendo del juego..."); 
    }

    public void Reintentar()
    {
        SceneManager.LoadScene("Juego");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
