using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StalkerEnemy : MonoBehaviour
{
    [SerializeField] public GameObject focus;
    [SerializeField] public float delay;
    [SerializeField] public float velocidade;
    //[SerializeField] public double x = 0f;
    //[SerializeField] public float y = 0f;

    double x = 0f;
    float y = 0f;
    float tempo = 0f;

    float proporcao = 0;
    bool catched = false;

    float subx = 0;
    float suby = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Time.time - tempo);
        //Debug.Log(transform.position.x);
        //Debug.Log(transform.position.y);

        if (Time.time - tempo > delay)
        {
            tempo = Time.time;
            x = Mathf.Sqrt(Mathf.Pow((focus.transform.position.x - transform.position.x), 2));
            y = Mathf.Sqrt(Mathf.Pow((focus.transform.position.y - transform.position.y), 2));

            if (x == 0 && y == 0)
            {
                catched = true;
                proporcao = 1f;
            }
            else
            {
                if (y == 0)
                {
                    y += 0.01f;
                }

                if (x / y < 0.2)
                {
                    subx = 0;
                    if (transform.position.y > focus.transform.position.y)
                    {
                        suby = -velocidade;
                    }
                    else
                    {
                        suby = velocidade;
                    }
                }
                else if (x / y >= 0.2 && x / y < 0.40)
                {
                    if (transform.position.y > focus.transform.position.y)
                    {
                        suby = -velocidade * (1 - 0.2f);
                    }
                    else
                    {
                        suby = velocidade * (1 - 0.2f);
                    }
                    if (transform.position.x < focus.transform.position.x)
                    {
                        subx = velocidade * (1 - 0.8f);
                    }
                    else
                    {
                        subx = -velocidade * (1 - 0.8f);
                    }
                }
                else if (x / y >= 0.4 && x / y < 0.6)
                {
                    if (transform.position.y > focus.transform.position.y)
                    {
                        suby = -velocidade * (1 - 0.2f); ;
                    }
                    else
                    {
                        suby = velocidade * (1 - 0.2f);
                    }
                    if (transform.position.x < focus.transform.position.x)
                    {
                        subx = velocidade * (1 - 0.6f);
                    }
                    else
                    {
                        subx = -velocidade * (1 - 0.6f);
                    }
                }
                else if (x / y >= 0.6 && x / y < 0.8)
                {
                    if (transform.position.x < focus.transform.position.x)
                    {
                        subx = velocidade * (1 - 0.5f);
                    }
                    else
                    {
                        subx = -velocidade * (1 - 0.5f);
                    }
                    if (transform.position.y > focus.transform.position.y)
                    {
                        suby = -velocidade * (1 - 0.4f);
                    }
                    else
                    {
                        suby = velocidade * (1 - 0.4f);
                    }
                }
                else if (x / y >= 0.8 && x / y < 1)
                {
                    if (transform.position.y > focus.transform.position.y)
                    {
                        suby = -velocidade * (1 - 0.4f);
                    }
                    else
                    {
                        suby = velocidade * (1 - 0.4f);
                    }
                    if (transform.position.x < focus.transform.position.x)
                    {
                        subx = velocidade * (1 - 0.45f);
                    }
                    else
                    {
                        subx = -velocidade * (1 - 0.45f);
                    }
                }
                else if (x / y >= 1 && x / y < 1.25)
                {
                    if (transform.position.y > focus.transform.position.y)
                    {
                        suby = -velocidade * (1 - 0.45f);
                    }
                    else
                    {
                        suby = velocidade * (1 - 0.45f);
                    }
                    if (transform.position.x < focus.transform.position.x)
                    {
                        subx = velocidade * (1 - 0.4f);
                    }
                    else
                    {
                        subx = -velocidade * (1 - 0.4f);
                    }
                }
                else if (x / y >= 1.25 && x / y < 1.666)
                {
                    if (transform.position.y > focus.transform.position.y)
                    {
                        suby = -velocidade * (1 - 0.5f);
                    }
                    else
                    {
                        suby = velocidade * (1 - 0.5f);
                    }
                    if (transform.position.x < focus.transform.position.x)
                    {
                        subx = velocidade * (1 - 0.4f);
                    }
                    else
                    {
                        subx = -velocidade * (1 - 0.4f);
                    }
                }
                else if (x / y >= 1.666 && x / y < 2.5)
                {
                    if (transform.position.y > focus.transform.position.y)
                    {
                        suby = -velocidade * (1 - 0.6f);
                    }
                    else
                    {
                        suby = velocidade * (1 - 0.6f);
                    }
                    if (transform.position.x < focus.transform.position.x)
                    {
                        subx = velocidade * (1 - 0.2f);
                    }
                    else
                    {
                        subx = -velocidade * (1 - 0.2f);
                    }
                }
                else if (x / y >= 2.5 && x / y < 5)
                {
                    if (transform.position.y > focus.transform.position.y)
                    {
                        suby = -velocidade * (1 - 0.8f);
                    }
                    else
                    {
                        suby = velocidade * (1 - 0.8f);
                    }
                    if (transform.position.x < focus.transform.position.x)
                    {
                        subx = velocidade * (1 - 0.2f);
                    }
                    else
                    {
                        subx = -velocidade * (1 - 0.2f);
                    }
                }
                else if (x / y >= 5 && x == 0)
                {
                    suby = 0;
                    if (transform.position.x < focus.transform.position.x)
                    {
                        subx = velocidade;
                    }
                    else
                    {
                        subx = -velocidade;
                    }
                }

                //Vector2 movimento = new Vector2(transform.position.x + (subx/100), transform.position.y + (suby/100));
                //Vector2 movimento = new Vector2( subx, suby );
                transform.Translate(subx/10, suby/10, 0);
                //transform.position = movimento * Time.deltaTime;
                //Debug.Log(movimento);
            }
        }
    }
}