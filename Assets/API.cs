using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class API : MonoBehaviour {

private const string Endpoints = "http://35.231.191.140/nxt?requestType=getAccount&account=";
private const string API_key = "BLX-72NL-2RTT-X3K7-5NZCX";
public Text responseText;

public void Request()
{
	WWWForm form = new WWWForm();

	
	WWW request = new WWW(Endpoints+API_key);
	StartCoroutine(OnResponse(request));
}


private IEnumerator OnResponse(WWW req)
{
 yield return req;
responseText.text = req.text;
}




}
