using Assets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LataDeLixo : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision) {

        string tipoLixo = PropriedadesEntidade.GetTipoLixo();
        if (tipoLixo == "Pl�stico") {
            Destroy(collision.gameObject);
            ProgressoObjetivo.SetLixosColetados();
        } else {

        }
    }

}
