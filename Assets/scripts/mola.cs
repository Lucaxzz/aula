using UnityEngine;

public class Mola : MonoBehaviour
{
    public float force = 10f; // Força inicial da mola
    public float maxForce = 20f; // Força máxima que o jogador pode aplicar

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) // Verifica se é o jogador que colidiu
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                // Calcular a direção para onde o jogador deve ser lançado
                Vector3 direction = transform.up.normalized;

                // Aplicar a força ao jogador na direção calculada
                rb.AddForce(direction * force, ForceMode.Impulse);
            }
        }
    }
}
