using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MilkResourceScript : MonoBehaviour
{
    public static int MilkGatheringRate = 33;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MilkGen());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MilkGen()
    {
        yield return new WaitForSeconds(10);
        ResourceManagmentTest.MilkResource += MilkGatheringRate;
        StartCoroutine(MilkGen());
    }
}
