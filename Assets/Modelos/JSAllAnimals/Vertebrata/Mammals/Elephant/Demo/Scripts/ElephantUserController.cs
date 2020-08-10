using UnityEngine;
using System.Collections;

public class ElephantUserController : MonoBehaviour {
	ElephantCharacter elephantCharacter;
	public float aleatorio;
	
	void Start () {
		elephantCharacter = GetComponent <ElephantCharacter> ();
		Acciones();
	}
	
	void Acciones () {		
		aleatorio = 2;//Random.Range(1,3);
		
		if(aleatorio == 1){
			StartCoroutine(Eat());
		}
		else if(aleatorio == 2){
			StartCoroutine(Sleeping());
		}
		else if(aleatorio == 3){
			StartCoroutine(Hit());
		}
	}
	
	private IEnumerator Eat(){
		yield return new WaitForSecondsRealtime(5);
		elephantCharacter.Eat();
		yield return new WaitForSecondsRealtime(5);
	}
	
	private IEnumerator Sleeping()
    {
		yield return new WaitForSecondsRealtime(5);
		elephantCharacter.Death();
        yield return new WaitForSecondsRealtime(30);
		elephantCharacter.Rebirth();
    }
	
	private IEnumerator Hit(){
		yield return new WaitForSecondsRealtime(5);
		elephantCharacter.Hit();
		yield return new WaitForSecondsRealtime(5);
	}
}
