    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerMenu : MonoBehaviour
{
    [SerializeField] GameObject PanelNotificacionSalir;
    [SerializeField] GameObject PanelEscenarios;
    [SerializeField] GameObject PanelMenuPrincipal;

    [SerializeField] string Nivel1;

    [SerializeField] string EcenarioNivel1;
    [SerializeField] string EcenarioNivel2;
    [SerializeField] string EcenarioNivel3;
    [SerializeField] string EcenarioNivel4;
    [SerializeField] string EcenarioNivel5;


    public void SeleccionNivel1()
    {
        SceneManager.LoadScene(EcenarioNivel1);
        Debug.Log("Abriendo Nivel 1...");
        Time.timeScale = 1f;
    }
    public void SeleccionNivel2()
    {
        SceneManager.LoadScene(EcenarioNivel2);
        Debug.Log("Abriendo Nivel 2...");
        Time.timeScale = 1f;
    }
    public void SeleccionNivel3()
    {
        SceneManager.LoadScene(EcenarioNivel3);
        Debug.Log("Abriendo Nivel 3...");
        Time.timeScale = 1f;
    }
    public void SeleccionNivel4()
    {
        SceneManager.LoadScene(EcenarioNivel4);
        Debug.Log("Abriendo Nivel 4...");
        Time.timeScale = 1f;
    }
    public void SeleccionNivel5()
    {
        SceneManager.LoadScene(EcenarioNivel5);
        Debug.Log("Abriendo Nivel 5...");
        Time.timeScale = 1f;
    }


    public void AbrirPanelEcenarios()
    {
        PanelEscenarios.SetActive(true);
        PanelMenuPrincipal.SetActive(false);
    }
    public void RegresarAlPanelMenuPrincipal()
    {
        PanelMenuPrincipal.SetActive(true);
        PanelEscenarios.SetActive(false);
    }

    public void ActivarNotificacionSalir()
    {
        PanelNotificacionSalir.SetActive(true);
    }

    public void SalirSi()
    {
        Application.Quit();
        Debug.Log("Salio del juego");
    }
    public void SalirNo()
    {
        PanelNotificacionSalir.SetActive(false);
        Debug.Log("no salio del juego");
    }

    public void IniciarJuego()
    {
        //SceneManager.LoadScene(Nivel1);

        Debug.Log("Inicio el juego");
    }




}
