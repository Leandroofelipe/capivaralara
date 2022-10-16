using Assets;
using UnityEngine;


public class LataLixoPlastico : MonoBehaviour
{
    public Animator animator;

    private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.tag == "Pl�stico") {
            Destroy(collision.gameObject);
            ProgressoObjetivo.SetLixosColetados();
            animator.SetInteger("lixosColetados", ProgressoObjetivo.GetLixosColetados());
        } else {
            ProgressoObjetivo.FalaCapivara(3);
        }
    }

}