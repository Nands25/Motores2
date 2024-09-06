using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        float movimentoH = 0f;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            movimentoH = 1f;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            movimentoH = -1f;
        }
        else
        {
            movimentoH = 0;
        }

        transform.position += new Vector3(movimentoH, 0f, 0f) * speed * Time.deltaTime;

        float movimentoV = 0f;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            movimentoV = 1f;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            movimentoV = -1f;
        }
        
        
        transform.position += new Vector3(0f, movimentoV, 0f) * speed * Time.deltaTime;
    }
}
