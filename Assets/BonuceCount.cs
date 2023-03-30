using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonuceCount : MonoBehaviour
{
    public int bonuces = 0;

    private void OnCollisionEnter(Collision collision)
    {
        bonuces++;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
