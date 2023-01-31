using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopSystem : MonoBehaviour
{
    // The amount of gold the player has
    public int gold = Player.CashMoney;

    // The UI text element that displays the player's gold
    public TextMeshProUGUI goldText;

    // The UI for resources
    public TextMeshProUGUI MilkResourceAmount;
    public TextMeshProUGUI WoolResourceAmount;
    public TextMeshProUGUI SilkResourceAmount;

    void Start()
    {

    }

     void Update()
    {
        //MILK
        MilkResourceAmount.text = ResourceManagmentTest.MilkResource.ToString();
        //WOOL
        WoolResourceAmount.text = ResourceManagmentTest.WoolResource.ToString();
        //SILK
        SilkResourceAmount.text = ResourceManagmentTest.SilkResource.ToString();
        //CASH
        goldText.text = Player.CashMoney.ToString();
    }

  // This function is called when the player clicks the "Sell Milk" button
    public void SellMilk()
    {
        if (ResourceManagmentTest.MilkResource > 0) // Make sure the player has milk to sell
        {
            Player.CashMoney += 5; // Increase the player's gold by 10
            ResourceManagmentTest.MilkResource -= 1; // Decrease the player's milk by 1
            goldText.text = Player.CashMoney.ToString(); // Update the gold UI text
        }
    }

    public void SellMilkBIG()
    {
        if (ResourceManagmentTest.MilkResource > 10) // Make sure the player has milk to sell
        {
            Player.CashMoney += 50; // Increase the player's gold by 10
            ResourceManagmentTest.MilkResource -= 10; // Decrease the player's milk by 10
            goldText.text = Player.CashMoney.ToString(); // Update the gold UI text
        }
    }

      // This function is called when the player clicks the "Sell Wool" button
    public void SellWool()
    {
        if (ResourceManagmentTest.WoolResource > 0) // Make sure the player has wool to sell
        {
            Player.CashMoney += 8; // Increase the player's gold by 10
            ResourceManagmentTest.WoolResource -= 1; // Decrease the player's wool by 1
            goldText.text = Player.CashMoney.ToString(); // Update the gold UI text
        }
    }

    public void SellWoolBIG()
    {
        if (ResourceManagmentTest.WoolResource > 10) // Make sure the player has wool to sell
        {
            Player.CashMoney += 80; // Increase the player's gold by 10
            ResourceManagmentTest.WoolResource -= 10; // Decrease the player's wool by 10
            goldText.text = Player.CashMoney.ToString(); // Update the gold UI text
        }
    }

      // This function is called when the player clicks the "Sell Silk" button
    public void SellSilk()
    {
        if (ResourceManagmentTest.SilkResource > 0) // Make sure the player has silk to sell
        {
            Player.CashMoney += 15; // Increase the player's gold by 10
            ResourceManagmentTest.SilkResource -= 1; // Decrease the player's silk by 1
            goldText.text = Player.CashMoney.ToString(); // Update the gold UI text
        }
    }

      public void SellSilkBIG()
    {
        if (ResourceManagmentTest.SilkResource > 10) // Make sure the player has silk to sell
        {
            Player.CashMoney += 150; // Increase the player's gold by 10
            ResourceManagmentTest.SilkResource -= 10; // Decrease the player's silk by 10
            goldText.text = Player.CashMoney.ToString(); // Update the gold UI text
        }
    }

    // This function is called when the player clicks the "Buy Milk" button
    public void BuyMilk()
    {
        if (Player.CashMoney > 5) // Make sure the player has gold
        {
            Player.CashMoney -= 5; // Decrease the player's gold by 5
            ResourceManagmentTest.MilkResource += 1; // Increase the player's milk by 1
            goldText.text = Player.CashMoney.ToString(); // Update the gold UI text
        }
    }

    public void BuyMilkBIG()
    {
        if (Player.CashMoney > 50) // Make sure the player has gold
        {
            Player.CashMoney -= 50; // Decrease the player's gold by 50
            ResourceManagmentTest.MilkResource += 10; // Increase the player's milk by 10
            goldText.text = Player.CashMoney.ToString(); // Update the gold UI text
        }
    }

     // This function is called when the player clicks the "Buy Wool" button
    public void BuyWool()
    {
        if (Player.CashMoney > 8) // Make sure the player has gold
        {
            Player.CashMoney -= 8; // Decrease the player's gold by 8
            ResourceManagmentTest.WoolResource += 1; // Increase the player's wool by 1
            goldText.text = Player.CashMoney.ToString(); // Update the gold UI text
        }
    }

    public void BuyWoolBIG()
    {
        if (Player.CashMoney > 80) // Make sure the player has gold
        {
            Player.CashMoney -= 80; // Decrease the player's gold by 50
            ResourceManagmentTest.WoolResource += 10; // Increase the player's wool by 10
            goldText.text = Player.CashMoney.ToString(); // Update the gold UI text
        }
    }

    // This function is called when the player clicks the "Buy Silk" button
    public void BuySilk()
    {
        if (Player.CashMoney > 15) // Make sure the player has gold
        {
            Player.CashMoney -= 15; // Decrease the player's gold by 8
            ResourceManagmentTest.SilkResource += 1; // Increase the player's wool by 1
            goldText.text = Player.CashMoney.ToString(); // Update the gold UI text
        }
    }

    public void BuySilkBIG()
    {
        if (Player.CashMoney > 150) // Make sure the player has gold
        {
            Player.CashMoney -= 150; // Decrease the player's gold by 50
            ResourceManagmentTest.SilkResource += 10; // Increase the player's silk by 10
            goldText.text = Player.CashMoney.ToString(); // Update the gold UI text
        }
    }
}
