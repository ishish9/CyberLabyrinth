using UnityEngine;

public class FallResetTrigger : MonoBehaviour
{
    [SerializeField] private Timer script1;
    [SerializeField] private GameObject Player;
    [SerializeField] private ParticleSystem FallParticle;
    [SerializeField] private Transform FallParticleLocation;
    [SerializeField] private AudioSource FallSound;

    void OnTriggerEnter()
    {
        script1.FallDeath();
        Player.SetActive(false);
        FallParticleLocation.position = Player.transform.position;
        FallParticle.Play();
        FallSound.Play();
    }
}
