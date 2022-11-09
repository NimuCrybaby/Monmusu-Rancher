using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoolResourceScript : MonoBehaviour
{
    public static int WoolGatheringRate = 12;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WoolGen());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator WoolGen()
    {
        yield return new WaitForSeconds(10);
        ResourceManagmentTest.WoolResource += WoolGatheringRate;
        StartCoroutine(WoolGen());
    }
}
