using System.Collections;
using UnityEngine;

public class MissileCollide : MonoBehaviour
{
    [Header("Parts")]
    public GameObject Explosion;
    public MeshRenderer mesh;
    public GameObject Missile;

    [Header("Stats")]
    public float power = 10.0f;
    public float radius = 5.0f;
    public float upforce = 0f;

    private void OnTriggerEnter(Collider other)
    {
        GameObject Clone = Instantiate(Explosion, transform.position, transform.rotation);
        mesh.enabled = false;
        Vector3 explosionPosition = Missile.transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPosition,radius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(power, explosionPosition, radius, upforce, ForceMode.Impulse);
            }
        }
        
        StartCoroutine(KillClone(Clone));
    }
    IEnumerator KillClone(GameObject Clone)
    {
        yield return new WaitForSeconds(1.5f);
        Destroy(gameObject);
        Destroy(Clone);
    }
}
