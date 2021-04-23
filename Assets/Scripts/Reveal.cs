//Shady
using UnityEngine;

[ExecuteInEditMode]
public class Reveal : MonoBehaviour
{
    public Material Mat;
    public Light SpotLight;
	
	void Update ()
    {
        Mat.SetVector("_LightPosition",  SpotLight.transform.position);
        Mat.SetVector("_LightDirection", -SpotLight.transform.forward );
        Mat.SetFloat ("_LightAngle", SpotLight.spotAngle);
    }//Update() end
}//class end