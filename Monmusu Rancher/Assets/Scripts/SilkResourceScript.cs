using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SilkResourceScript : MonoBehaviour
{
    public static int SilkGatheringRate = 3;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SilkGen());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SilkGen()
    {
        yield return new WaitForSeconds(10);
        ResourceManagmentTest.SilkResource += SilkGatheringRate;
        StartCoroutine(SilkGen());
    }
}
