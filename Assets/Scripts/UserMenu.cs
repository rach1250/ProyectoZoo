using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UserMenu : MonoBehaviour
{
	public string escena;

    // Start is called before the first frame update
    void Start()
    {
        escena = SceneManager.GetActiveScene().name;
    }

    public void Back(){
		escena = SceneManager.GetActiveScene().name;
		switch(escena){
			case "Leon Vista Usuario":
				SceneManager.LoadScene("Leon Ambiente");
				break;
			case "Gorila Vista Usuario":
				SceneManager.LoadScene("Gorila Ambiente");
				break;
			case "Elefante Vista Usuario":
				SceneManager.LoadScene("Elefante Ambiente");
				break;
			case "Oso Vista Usuario":
				SceneManager.LoadScene("Oso Ambiente");
				break;
			case "Cebra Vista Usuario":
				SceneManager.LoadScene("Cebra Ambiente");
				break;
			case "Jirafa Vista Usuario":
				SceneManager.LoadScene("Jirafa Ambiente");
				break;
		}
	}
}