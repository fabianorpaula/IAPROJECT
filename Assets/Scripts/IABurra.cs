using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IABurra : MonoBehaviour
{
    public GameObject Destino;

    void Update()
    {
        Vector3 meuPontoAtual = transform.position;
        Vector3 meuDestino = Destino.transform.position;
        transform.position = Vector3.MoveTowards(meuPontoAtual, meuDestino, 0.01f);
    }
}
