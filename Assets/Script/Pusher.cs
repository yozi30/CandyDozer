using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pusher : MonoBehaviour
{
    int num = 0;
    
    public GameObject gameobject = default;

    // Start is called before the first frame update
    void Start()
    {
        num = 1 + 1;
        Debug.Log(num);
    }

    // Update is called once per frame
    void Update()
    {
        gameobject.transform.position = gameobject.transform.position +  new Vector3(0,0,-1);
                                                                            //z上の値を加算する
    }
}
