using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamemanager : MonoBehaviour
{
    public static gamemanager Instance;

    //public GameObject[] Estrellas;

    public GameObject HUD;

    public GameObject Marco;

    public GameObject Victoria;

    public GameObject Jugador;

    public int contadorEstrellas;

    public Text estrellaText;

    void Awake()
    {

        if(Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }

        DontDestroyOnLoad(this);

    }

    public void RestarVidas()
    {

        /*if(contadorEstrellas == 1)
        {
            HUD.SetActive(false);
            Marco.SetActive(true);
            Victoria.SetActive(true);
            Jugador.SetActive(false);
        }*/
    }

    public void SumarEstrellas()
    {
        contadorEstrellas = contadorEstrellas + 1;
        Debug.Log("estrellita " + contadorEstrellas);
        estrellaText.text = contadorEstrellas.ToString();

        if(contadorEstrellas == 10)
        {
            HUD.SetActive(false);
            Marco.SetActive(true);
            //Victoria.SetActive(true);
            Jugador.SetActive(false); 
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}