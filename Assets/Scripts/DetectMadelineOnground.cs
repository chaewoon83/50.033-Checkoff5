using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectMadelineOnground : MonoBehaviour
{
    public BoolVariable OnGround;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.gameObject.layer == 6)
        {
            Debug.Log("OnGround");
            OnGround.SetValue(true);
        }
    }
}
