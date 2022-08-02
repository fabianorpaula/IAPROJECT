using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IAMonstro : MonoBehaviour
{

    //Uma aplicação que consegue ir para todos os destinos de uma lista, ela trabalha no sentido randomico,
    //sempre que encontra um destino, segue para o próximo.
    //Quando encontra uma Flag(Tesouro) para.

    public GameObject Destino;
    public NavMeshAgent Agente;
    public List<GameObject> Destinos;
    public GameObject Tesouro;
    public bool objetivo = false;
    public int numero;

    private void Start()
    {
        numero = Random.Range(0, 5);
        Destino = Destinos[numero];

       
    }
    void Update()
    {
        if (objetivo == false)
        {
            Vector3 meuDestino = Destino.transform.position;
            Agente.SetDestination(meuDestino);
            if (Vector3.Distance(transform.position, Tesouro.transform.position) < 10)
            { objetivo = true; }

            if (Vector3.Distance(transform.position, meuDestino) < 8)
            {
                numero = Random.Range(0, 5);
                Destino = Destinos[numero];
            }
        }
    }
}
