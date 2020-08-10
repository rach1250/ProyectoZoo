using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeleccionMenu : MonoBehaviour
{
    public void Back(){
		SceneManager.LoadScene("Main Menu");
	}
	
	public void EscenarioLeon(){
		SceneManager.LoadScene("Leon Ambiente");
	}
	
	public void EscenarioElefante(){
		SceneManager.LoadScene("Elefante Ambiente");
	}
	
	public void EscenarioGorila(){
		SceneManager.LoadScene("Gorila Ambiente");
	}
	
	public void EscenarioOso(){
		SceneManager.LoadScene("Oso Ambiente");
	}
	
	public void EscenarioCebra(){
		SceneManager.LoadScene("Cebra Ambiente");
	}
	
	public void EscenarioJirafa(){
		SceneManager.LoadScene("Jirafa Ambiente");
	}
}
