using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appear : MonoBehaviour
{
    public GameObject toAppear;
    public int appearAt;
    private float time = 0;
    private bool appeared = false;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > appearAt && appeared == false)
        {
            toAppear.SetActive(true);
            appeared = true;
        }
    }
}
