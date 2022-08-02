using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IABurra : MonoBehaviour
{

    //Uma aplicação simples que vai em direção ao destino ignorando a fisica do objeto.

    public GameObject Destino;

    void Update()
    {
        Vector3 meuPontoAtual = transform.position;
        Vector3 meuDestino = Destino.transform.position;
        transform.position = Vector3.MoveTowards(meuPontoAtual, meuDestino, 0.01f);
    }
}
