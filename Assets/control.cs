using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class control : MonoBehaviour {
public Text DisplayText;
public Text inputText;



public string assetID;
BlockchainData data;
private int bal;

private const string EndpointsAcc = "http://35.231.191.140/nxt?requestType=getAccount&account=";
private const string EndpointsAsset = "http://35.231.191.140/nxt?requestType=getAccountAssets&account=";




	public void checkBalance()
    { 
	WWW requestACC = new WWW(EndpointsAcc+inputText.text);
    

	StartCoroutine(OnResponse(requestACC));
  
	}



private IEnumerator OnResponse(WWW req)
{
        yield return req;
        data = JsonUtility.FromJson<BlockchainData>(req.text);
         
        if (data.quantityQNT != null)
        {
           // DisplayText.text = " NAME: " + data.name + "\n" + " GAS: " + data.balanceNQT ;
          
           DisplayText.text = data.quantityQNT;
           
             
            
        }
        else if(data.balanceNQT != null)
        {
                DisplayText.text = data.balanceNQT;
}
            else
            {
                DisplayText.text = "Error";
            }
    }

  

public void checkAsset()
{
    WWW requestAsset = new WWW (EndpointsAsset+inputText.text+"&"+"asset="+assetID);
      StartCoroutine(OnResponse(requestAsset));
       
}








}


