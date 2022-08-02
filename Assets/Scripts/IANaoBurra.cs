using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IANaoBurra : MonoBehaviour
{
    //Uma aplicação que mapeia o terreno, e segue o melhor caminho

    public GameObject Destino;
    public NavMeshAgent Agente;
   

    // Update is called once per frame
    void Update()
    {
        Vector3 meuDestino = Destino.transform.position;
        Agente.SetDestination(meuDestino);
    }
}
