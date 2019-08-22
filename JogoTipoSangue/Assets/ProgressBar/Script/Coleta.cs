using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coleta : MonoBehaviour

{

    public static Coleta instancia;
    GameObject vidaPer;
    Collider2D coliderPer;
   [SerializeField] Collider2D[] sangue;



    private void Awake()
    {
        
        if(instancia == null)
        {
            instancia = this;

        }
        else if (this != instancia)
        {
            Destroy(this);
        }
    }



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
        
    }
}
