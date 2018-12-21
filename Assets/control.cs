using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class control : MonoBehaviour {
public Text DisplayText;
public Text inputText;
BlockchainData data;

private const string Endpoints = "http://35.231.191.140/nxt?requestType=getAccount&account=";




	public void checkBalance()
    { 
	WWW request = new WWW(Endpoints+inputText.text);
	StartCoroutine(OnResponse(request));
	}



private IEnumerator OnResponse(WWW req)
{
        yield return req;
        data = JsonUtility.FromJson<BlockchainData>(req.text);
        if (data.balanceNQT != null)
            DisplayText.text = data.balanceNQT;
        else
            DisplayText.text = "ERROR!";
    }
}
