using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IAInteligente : MonoBehaviour
{
    //uma aplicação que consegue entender qual destino é mais proximo, e ir em direção a ele.

    public GameObject Destino;
    public NavMeshAgent Agente;
    public GameObject Destino1;
    public GameObject Destino2;

    // Update is called once per frame
    void Update()
    {
        if (CalculaDistancia(Destino1) > CalculaDistancia(Destino2))
        {
            Destino = Destino2;
        }
        else
        {
            Destino = Destino1;
        }

        Vector3 meuDestino = Destino.transform.position;
        Agente.SetDestination(meuDestino);
    }

    float CalculaDistancia(GameObject dest)
    {

        float distanciaTotal = Vector3.Distance(transform.position, dest.transform.position);

        return distanciaTotal;
    }

}
