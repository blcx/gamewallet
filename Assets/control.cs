using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class control : MonoBehaviour {

public Text returnResponsText;
public Text inputText;
public string JSON;
private BlockchainData data;


private const string Endpoints = "http://35.231.191.140/nxt?requestType=getAccount&account=";


	public void checkBalance()
	{
	WWW request = new WWW(Endpoints+inputText.text);
	StartCoroutine(OnResponse(request));
	}



private IEnumerator OnResponse(WWW req)
{
 yield return req;
 Debug.Log(req.text);
JSON = req.text;
data = JsonUtility.FromJson<BlockchainData>(JSON);

if (data != null && data.assetBalances != null && data.assetBalances.Length > 0)
    returnResponsText.text = data.assetBalances[0].balanceQNT;
    else
     returnResponsText.text = "INVALID JSON!";
 

}



}
