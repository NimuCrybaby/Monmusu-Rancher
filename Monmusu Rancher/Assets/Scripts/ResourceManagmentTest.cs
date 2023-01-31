using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResourceManagmentTest : MonoBehaviour
{
    //CELY TENTO SKRIPT JE MRTE NA KOKOT

    //MONEY
    public int Money = Player.CashMoney;
    public TextMeshProUGUI MoneyText;
    //MILK
    public static int MilkResource;
    public static int MilkResourceGatheringRate;
    public TextMeshProUGUI MilkResourceText;
    public TextMeshProUGUI MilkResourceTextInFactory;
    public TextMeshProUGUI MilkResourceAmount;

    //WOOL
    public static int WoolResource;
    public static int WoolResourceGatheringRate;
    public TextMeshProUGUI WoolResourceText;
    public TextMeshProUGUI WoolResourceTextInFactory;
    public TextMeshProUGUI WoolResourceAmount;

    //SILK
    public static int SilkResource;
    public static int SilkResourceGatheringRate;
    public TextMeshProUGUI SilkResourceText;
    public TextMeshProUGUI SilkResourceTextInFactory;
    public TextMeshProUGUI SilkResourceAmount;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MilkResourceGatheringRate = MilkResourceScript.MilkGatheringRate;
        WoolResourceGatheringRate = WoolResourceScript.WoolGatheringRate;
        SilkResourceGatheringRate = SilkResourceScript.SilkGatheringRate;
        //AJ TOTO JE NAPIČU
        //MONEY
        MoneyText.text = Player.CashMoney.ToString();
        //MILK
        MilkResourceAmount.text = MilkResource.ToString();
        MilkResourceText.text = MilkResourceGatheringRate.ToString() + "/min";
        MilkResourceTextInFactory.text = MilkResourceGatheringRate.ToString() + "/min";
        //WOOL
        WoolResourceAmount.text = WoolResource.ToString();
        WoolResourceText.text = WoolResourceGatheringRate.ToString() + "/min";
        WoolResourceTextInFactory.text = WoolResourceGatheringRate.ToString() + "/min";
        //SILK
        SilkResourceAmount.text = SilkResource.ToString();
        SilkResourceText.text = SilkResourceGatheringRate.ToString() + "/min";
        //SilkResourceTextInFactory.text = SilkResourceGatheringRate.ToString() + "/min";
    }
}
