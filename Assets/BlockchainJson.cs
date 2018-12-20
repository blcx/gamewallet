using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class BlockchainData
{
    public string unconfirmedBalanceNQT;
    public int effectiveBalanceNXT;
    public Lessorsinfo[] lessorsInfo;
    public string currentLessee;
    public int currentLeasingHeightTo;
    public string forgedBalanceNQT;
    public string balanceNQT;
    public string publicKey;
    public int requestProcessingTime;
    public Assetbalance[] assetBalances;
    public string guaranteedBalanceNQT;
    public Unconfirmedassetbalance[] unconfirmedAssetBalances;
    public string currentLesseeRS;
    public string accountRS;
    public string name;
    public string account;
    public int currentLeasingHeightFrom;
}
[System.Serializable]
public class Lessorsinfo
{
    public string currentHeightTo;
    public string nextHeightFrom;
    public string effectiveBalanceNXT;
    public string nextLesseeRS;
    public string currentLesseeRS;
    public string currentHeightFrom;
    public string nextHeightTo;
}
[System.Serializable]
public class Assetbalance
{
    public string balanceQNT;
    public string asset;
}
[System.Serializable]
public class Unconfirmedassetbalance
{
        public string unconfirmedBalanceQNT;
        public string asset;
}

