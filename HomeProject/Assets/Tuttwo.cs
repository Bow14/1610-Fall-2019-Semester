using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuttwo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int MyGoodInt = 10;
        MyGoodInt = 45;
            Debug.Log(MyGoodInt * 4);
            {
                MyGoodInt = MultiplyBySix(MyGoodInt);
                Debug.Log(MyGoodInt);
            }
            int MultiplyBySix(int number)
            {
                int ret;
                ret = number * 6;
                return ret;
            }

    }

    // Update is called once per frame
}
