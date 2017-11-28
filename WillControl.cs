using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WillControl : MonoBehaviour {

    public GameObject coin1;
    public GameObject coin2;
    public GameObject coin3;

    public Text t1;

    private bool coin1Taken;
    private bool coin2Taken;
    private bool coin3Taken;

    private float coin1Distance;
    private float coin2Distance;
    private float coin3Distance;

	// Use this for initialization
	void Start () {
        coin1Taken = false;
        coin2Taken = false;
        coin3Taken = false;
        t1.text = "";
        coin1Distance = (transform.position - coin1.transform.position).sqrMagnitude;
        coin2Distance = (transform.position - coin2.transform.position).sqrMagnitude;
        coin3Distance = (transform.position - coin3.transform.position).sqrMagnitude;
    }
	
    void Kill()
    {
        t1.text = "YOU LOSE!!!!";
        //gameObject.SetActive(false);
    }
	// Update is called once per frame
	void Update () {
        coin1Distance = (transform.position - coin1.transform.position).sqrMagnitude;
        coin2Distance = (transform.position - coin2.transform.position).sqrMagnitude;
        coin3Distance = (transform.position - coin3.transform.position).sqrMagnitude;
        bool press_e = Input.GetKeyDown(KeyCode.E);
        if (press_e)
        {
            if (coin1Distance < 5.0f && !coin1Taken)
            {
                coin1.SetActive(false);
                coin1Taken = true;
            }
            if (coin2Distance < 5.0f && !coin2Taken)
            {
                coin2.SetActive(false);
                coin2Taken = true;
            }
            if (coin3Distance < 5.0f && !coin3Taken)
            {
                coin3.SetActive(false);
                coin3Taken = true;
            }
        }
        if(coin1Taken && coin2Taken && coin3Taken)
        {
            t1.text = "YOU WIN!!!!";
        }
    }
}
