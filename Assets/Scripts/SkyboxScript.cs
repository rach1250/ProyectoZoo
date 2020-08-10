using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxScript : MonoBehaviour
{
    public Material [] skyboxes = new Material [7];
	// Start is called before the first frame update
    void Start()
    {
        RenderSettings.skybox = skyboxes[0];
		CambiarSkyBox();
    }

    // Update is called once per frame
    public void CambiarSkyBox()
    {
		StartCoroutine(Wait());
    }
	
	private IEnumerator Wait(){
		yield return new WaitForSecondsRealtime(6);
		RenderSettings.skybox = skyboxes[1];
		yield return new WaitForSecondsRealtime(6);
		RenderSettings.skybox = skyboxes[2];
		yield return new WaitForSecondsRealtime(6);
		RenderSettings.skybox = skyboxes[3];
		yield return new WaitForSecondsRealtime(6);
		RenderSettings.skybox = skyboxes[4];
		yield return new WaitForSecondsRealtime(6);
		RenderSettings.skybox = skyboxes[5];
		yield return new WaitForSecondsRealtime(6);
		RenderSettings.skybox = skyboxes[6];
	}
}
