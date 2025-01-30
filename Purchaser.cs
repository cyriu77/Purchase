using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;

public class Purchaser : MonoBehaviour
{
    public ShopManagerScript shopManager;
    void Start()
    {
        shopManager = FindObjectOfType<ShopManagerScript>();
    }
    public void OnPurchaseCompleted(Product product)
    {
        switch(product.definition.id)
        {
            case "com.Cyriu.CandySweetsBum.removeads":
                RemoveAds();
                break;
            case "com.Cyriu.CandySweetsBum.500coins":
                Add500Coins();
                break;
            //case "com.Cyriu.CandySweetsBum.vipcontent":
                //VipContent();
                //break;
            //case "com.Cyriu.CandySweetBum.rockbomb":
              //  RockBomb();
              //  break;//for future
            case "com.Cyriu.CandySweetBum.adjasbomb":
                AdjasBomb();
                break;
            case "com.Cyriu.CandySweetBum.rowbomb":
                RowBomb();
                break;
            case "com.Cyriu.CandySweetBum.colourbomb":
                ColourBomb();
                break;
            case "com.Cyriu.CandySweetBum.coloumnbomb":
                ColoumnBomb();
                break;
        }
    }

    private void RemoveAds()
    {
        PlayerPrefs.SetInt("removeads", 1);
        Debug.Log("Purchase: removeads");
        UIInfo.Instance.UpdateRemoveAdsButton();
    }

    private void Add500Coins()
    {
        int coins = PlayerPrefs.GetInt("coins");
        coins += 500;
        PlayerPrefs.SetInt("coins", coins);
        Debug.Log("Purchase: get 10 coins");
        UIInfo.Instance.UpdateCoinsText();
    }
   /* private void VipContent()
    {
        PlayerPrefs.SetInt("vipcontent", 1);
        Debug.Log("Purchase: vipcontent");
        UIInfo.Instance.UpdateVipContentButton();
        //PlayerPrefs.SetInt("vipcontent", 1);
        //vipContentBtn.SetActive(false);
        //vipContentBtn_afterBuy.SetActive(true);
        //UIInfo.Instance.UpdateVipContentButton();
        //Debug.Log("Purchase: vipcontent");
    }*/
    /*private void RocketB()
    {
        int quantity = PlayerPrefs.GetInt("quantity");
        quantity += 1;
        PlayerPrefs.SetInt("quantity", quantity);
        UIInfo.Instance.UpdateRocketBomb();
    }*/
    private void AdjasBomb()
    {
        //ShopManagerScript.Instance.BuyAdjas();
        shopManager.BuyAdjas();
        Debug.Log("buyadjas");
        //UIInfo.Instance.UpdateAdjasBomb();
    }
    /*private void RockBomb()
    {
        //ShopManagerScript.Instance.BuyRock();
        shopManager.BuyRock();
        Debug.Log("buyrock");
        //UIInfo.Instance.UpdateAdjasBomb();
    }*/
    private void RowBomb()
    {
        //ShopManagerScript.Instance.BuyRow();
        shopManager.BuyRow();
        Debug.Log("buyrowb");
        //UIInfo.Instance.UpdateAdjasBomb();
    }
    private void ColourBomb()
    {
        //ShopManagerScript.Instance.BuyColo();
        shopManager.BuyColo();
        Debug.Log("buycolor");
        //UIInfo.Instance.UpdateAdjasBomb();
    }
    private void ColoumnBomb()
    {
        //ShopManagerScript.Instance.BuyColo();
        shopManager.BuyColoumn();
        Debug.Log("buycoloumn");
        //UIInfo.Instance.UpdateAdjasBomb();
    }
    /* private void ColomnB()
     {
         shopManager.BuyColomn();
         //UIInfo.Instance.UpdateAdjasBomb();
     }*/
}

