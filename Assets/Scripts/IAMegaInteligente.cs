using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IAMegaInteligente : MonoBehaviour
{
    public GameObject Destino;
    public NavMeshAgent Agente;
    public GameObject Destino1;
    public GameObject Destino2;
    public GameObject Tesouro;
    public bool objetivo = false;

    private void Start()
    {
        float numero = Random.Range(0, 10);
        if(numero < 5)
        {Destino = Destino1;}
        else
        {Destino = Destino2;}
    }
    void Update()
    {
        if (objetivo == false)
        {
            Vector3 meuDestino = Destino.transform.position;
            Agente.SetDestination(meuDestino);
            if(Vector3.Distance(transform.position, Tesouro.transform.position) < 10)
            { objetivo = true;}

            if (Vector3.Distance(transform.position, meuDestino) < 10)
            {
                if (Destino == Destino1)
                { Destino = Destino2; }
                else if (Destino == Destino2)
                { Destino = Destino1; }
               
            }
        }
    }
}
