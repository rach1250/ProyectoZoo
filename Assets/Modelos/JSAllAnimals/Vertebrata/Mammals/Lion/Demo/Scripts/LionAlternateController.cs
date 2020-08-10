using UnityEngine;
using System.Collections;

public class LionAlternateController : MonoBehaviour {
	LionCharacter lionCharacter;
	public int estado;
	
	void Start () {
		lionCharacter = GetComponent < LionCharacter> ();		
	}	
		
	void Update () {
		
	}
	
	public void Parar() {
		lionCharacter.forwardSpeed = 0f;
	}
	
	public void Caminar() {
		lionCharacter.forwardSpeed = 1f;
	}
	public void Trotar() {
		lionCharacter.forwardSpeed = 2f;
	}
	public void Galopar() {
		lionCharacter.forwardSpeed = 3f;
	}
	public void Correr() {
		lionCharacter.forwardSpeed = 4f;
	}
	
	/*void Update(){
		if (Input.GetButtonDown ("Fire1")) {
			lionCharacter.Attack();
		}
		if (Input.GetButtonDown ("Jump")) {
			lionCharacter.Jump();
		}
		if (Input.GetKeyDown (KeyCode.H)) {
			lionCharacter.Hit();
		}
		if (Input.GetKeyDown (KeyCode.K)) {
			lionCharacter.Death();
		}
		if (Input.GetKeyDown (KeyCode.L)) {
			lionCharacter.Rebirth();
		}		
		if (Input.GetKeyDown (KeyCode.U)) {
			lionCharacter.StandUp();
		}		
		if (Input.GetKeyDown (KeyCode.J)) {
			lionCharacter.SitDown();
		}	
		if (Input.GetKeyDown (KeyCode.M)) {
			lionCharacter.LieDown();
		}		
		if (Input.GetKeyDown (KeyCode.N)) {
			lionCharacter.Sleep();
		}	
		if (Input.GetKeyDown (KeyCode.Y)) {
			lionCharacter.WakeUp();
		}	
		if (Input.GetKeyDown (KeyCode.R)) {
			lionCharacter.Roar();
		}		
		if (Input.GetKeyDown (KeyCode.G)) {
			lionCharacter.Gallop();
		}	
		if (Input.GetKeyDown (KeyCode.C)) {
			lionCharacter.Canter();
		}	
		if (Input.GetKeyDown (KeyCode.T)) {
			lionCharacter.Trot();
		}	
		if (Input.GetKeyUp (KeyCode.X)) {
			lionCharacter.Walk();
		}	

		lionCharacter.forwardSpeed=lionCharacter.maxWalkSpeed*Input.GetAxis ("Vertical");
		lionCharacter.turnSpeed= Input.GetAxis ("Horizontal");
	}*/	
}
