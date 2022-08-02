using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IANaoBurra : MonoBehaviour
{
    public GameObject Destino;
    public NavMeshAgent Agente;
   

    // Update is called once per frame
    void Update()
    {
        Vector3 meuDestino = Destino.transform.position;
        Agente.SetDestination(meuDestino);
    }
}
