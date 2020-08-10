using UnityEngine;
using System.Collections;

public class GorillaAlternateController : MonoBehaviour {
	GorillaCharacter gorillaCharacter;
	public int estado;
	
	void Start () {
		gorillaCharacter = GetComponent <GorillaCharacter> ();		
	}	
		
	void Update () {
		
	}
	
	public void Parar() {
		gorillaCharacter.forwardSpeed = 0f;
	}
	
	public void Caminar() {
		gorillaCharacter.forwardSpeed = 1f;
	}
	
	public void Trotar() {
		gorillaCharacter.forwardSpeed = 2f;
	}
}
