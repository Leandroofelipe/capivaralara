using Assets;
using UnityEngine;


public class LataLixoPlastico : MonoBehaviour
{
    public Animator animator;

    private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.tag == "Pl�stico") {
            Destroy(collision.gameObject);
            ProgressoObjetivo.SetLixosColetados();

            ChatBubble.AparecerBubble();
            var random = Random.Range(0, 3);
            switch (random) {
                case 0:
                    ChatBubble.GetChatBuBbleScript("Boa!");
                    break;
                case 1:
                    ChatBubble.GetChatBuBbleScript("Parab�ns!");
                    break;
                case 2:
                    ChatBubble.GetChatBuBbleScript("Isso a�!");
                    break;
                case 3:
                    ChatBubble.GetChatBuBbleScript("Isso mesmo!");
                    break;
                default:
                    ChatBubble.GetChatBuBbleScript("Dale!");
                    break;
            }

            animator.SetInteger("lixosColetados", ProgressoObjetivo.GetLixosColetados());
        } else {
            ChatBubble.AparecerBubble();
            ChatBubble.GetChatBuBbleScript("Tente outra lixeira!");
        }
    }

}