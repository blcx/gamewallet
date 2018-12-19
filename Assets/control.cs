using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class control : MonoBehaviour {
public Text returnResponsText;
public Text inputText;


private const string Endpoints = "http://35.231.191.140/nxt?requestType=getAccount&account=";




	public void checkBalance()
	{
		 


	WWW request = new WWW(Endpoints+inputText.text);
	StartCoroutine(OnResponse(request));
	}



private IEnumerator OnResponse(WWW req)
{
 yield return req;



returnResponsText.text = req.text;


}





}
