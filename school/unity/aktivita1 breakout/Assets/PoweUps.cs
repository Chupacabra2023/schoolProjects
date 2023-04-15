using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoweUps : MonoBehaviour
{

   
    protected List<GameObject> powerUps;


    

    // Start is called before the first frame update
    void Start()
    {
        powerUps = new List<GameObject>();
        powerUps.Clear();

        powerUps.Add(Resources.Load<GameObject>("LightBallPower"));
        powerUps.Add(Resources.Load<GameObject>("BigPaddlePower"));
        powerUps.Add(Resources.Load<GameObject>("Circle"));


    }
    public List<GameObject> returnListOfPowers()
    {
        return powerUps;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
