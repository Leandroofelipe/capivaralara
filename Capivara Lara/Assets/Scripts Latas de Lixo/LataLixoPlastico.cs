using Assets;
using UnityEngine;


public class LataLixoPlastico : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.tag == "Pl�stico") {
            Destroy(collision.gameObject);
            ProgressoObjetivo.SetLixosColetados();
        } else {
            //Evento CapivaraDialogoErro();
        }
    }

}