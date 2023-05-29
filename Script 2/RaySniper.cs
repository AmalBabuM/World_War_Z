using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaySniper : MonoBehaviour
{
    public static GameObject bullet1;//BULLET 1
    public static GameObject bullet2;//BULLET 2
    public static GameObject bullet3;//BULLET 3
   
    GameObject myCanvas;
    SniperAmmo gunAmmo;

    /*public Image[] bullet;*/

    public bool isFiring = false;
    public ParticleSystem muzzleFlash;
    public Transform raycastOrigin;

    public ParticleSystem hitEffect;


    public AudioClip gunShot;
    AudioSource audioSource;


    Ray ray;
    RaycastHit hitInfo;
    public Transform raycastDestination;
    int score = 0;

    //Amunation Reload//


    private int maxAmmunation = 3;
    private static int mag = 3;
    private int presetAmmunation;

    public float reloadingTime = 1.3f;
    private bool setReloading = false;

    //Amunation Reload//
    void Start()
    {
        myCanvas = GameObject.FindGameObjectWithTag("Player");
        gunAmmo = myCanvas.GetComponentInChildren<SniperAmmo>();
        bullet1 = GameObject.FindWithTag("SBUL1");
        bullet2 = GameObject.FindWithTag("SBUL2");
        bullet3 = GameObject.FindWithTag("SBUL3");
        
        presetAmmunation = maxAmmunation;
        audioSource = GetComponent<AudioSource>();
        /* rag=new ragdoll();*/
        /* ragdoll rag = new ragdoll();*/

        /* rag = GameObject.FindGameObjectWithTag("Box").GetComponent<ragdoll>();*/
    }
    private void Update()
    {   

        var item = GameObject.FindGameObjectWithTag("Player").GetComponentInParent<GeneralAction>();

        if (setReloading)
            return;// If the gun is reloading restrict firing action

        if (presetAmmunation <= 0 && mag > 0)
        {

            item.DoReload();
            StartCoroutine(Reload());

            gunAmmo.FireAmmo(presetAmmunation);

            return;
        }

        /* if (Input.GetKey("r") || ShouldReload())
         {
             item.DontReload();
             StartCoroutine(Reload());
         }*/


        if (Input.GetButtonDown("Fire1") && Input.GetButton("Fire2"))
        {

            StartFiring();
            gunAmmo.FireAmmo(presetAmmunation);



        }

        else
        {
            StopFiring();
        }



    }
    public void StartFiring()
    {
        /*        Vector3    deadPoint = redBall.position;
                Vector3 direction= deadPoint - raycastOrigin.position;*/
        /* RaycastHit hit;
         if(Physics.Raycast(raycastOrigin.position,raycastOrigin.transform.forward, out hit)) 
         {
             Debug.Log(hit.transform.name);
             Debug.DrawLine(raycastOrigin.position, hit.point, Color.green, 1f);

         }*/
        /*else
        {
            Debug.DrawLine(raycastOrigin.position, hit.point, Color.red, 1f);

        }*/
        /*Debug.Log(deadPoint);*/

        //Amunation Reload//
        if (mag == 0)
        {
            //Show ammo out text
            return;
        }
        presetAmmunation--;
        if (presetAmmunation == 0)
        {
            /*pickUp.MagSubb(mag);*/
            /* bullet[mag - 1].enabled = false;*/                            //IMAGE BULLET TURNED OFF
            /* ammo.MagSub();*/
            mag--;
            BulletIMG(mag);
            /*Debug.Log(mag);*/
        }
        //Amunation Reload//

        isFiring = true;
        muzzleFlash.Emit(1);

        audioSource.PlayOneShot(gunShot);

        ray.origin = raycastOrigin.position;
        ray.direction = raycastDestination.position - raycastOrigin.position;
        if (Physics.Raycast(ray, out hitInfo))
        {
            Debug.DrawLine(ray.origin, hitInfo.point, Color.red, 1.0f);
            Debug.Log(hitInfo.transform.name);
            hitEffect.transform.position = hitInfo.point;
            hitEffect.transform.forward = hitInfo.normal;
            hitEffect.Emit(1);
            if (hitInfo.collider.gameObject.tag == "Enemy")
            {

                /*Instantiate(boxPieces, hitInfo.collider.gameObject.transform.position, hitInfo.collider.gameObject.transform.rotation);*/
                /* hitInfo.collider.GetComponent<Animator>().enabled = false;
                 hitInfo.collider.GetComponent<NavMeshAgent>().enabled = false;

                 hitInfo.collider.GetComponent<NavEnemy>().enabled = false;
                 hitInfo.collider.GetComponent<CapsuleCollider>().enabled = false;*/
                /* hitInfo.collider.GetComponent<Rigidbody>().isKinematic = false;*/
                /*rag.EnableRagdoll();*/



                /*var enemy=hitInfo.collider.GetComponent<ragdoll>();
                enemy.DoRagDoll(true);*/

                var health = hitInfo.collider.GetComponent<ZombieHeath>();
                health.TakeDamage(200);


                /* Destroy(hitInfo.collider.gameObject, 10f);*/
                score += 1;
            }
            if (hitInfo.collider.gameObject.tag == "Box")
            {
                Destroy(hitInfo.collider.gameObject);
                score += 1;
            }
        }
        /*if(score >=10)
        {
            SceneManager.LoadScene(4);
        }*/


    }
    public void IncreaseMag()
    {

        mag += 1;
        /*pickUp.MagAdd(mag);*/
        /*bullet[mag - 1].enabled = true;*/
        /*ammo.MagAdd();*/
        /* Debug.Log(mag);*/
        /*bulletAdd();*/
        switch (mag)
        {
            case 0:

                bullet1.SetActive(false);
                bullet2.SetActive(false);
                bullet3.SetActive(false);

                break;
            case 1:

                bullet1.SetActive(true);
                bullet2.SetActive(false);
                bullet3.SetActive(false);

                break;
            case 2:
                bullet1.SetActive(true);
                bullet2.SetActive(true);
                bullet3.SetActive(false);
                break;

            case 3:
                bullet1.SetActive(true);
                bullet2.SetActive(true);
                bullet3.SetActive(true);

                break;


        }


    }


    IEnumerator Reload()
    {

        setReloading = true;
        Debug.Log("Reloading.....");
        //Play animation
        //Play sound
        yield return new WaitForSeconds(reloadingTime);
        /*RefillAmmo();*/
        presetAmmunation = maxAmmunation;
        gunAmmo.FireAmmo(presetAmmunation);


        setReloading = false;
        /*mag += 1;*/

    }


    public void StopFiring()
    {
        isFiring = false;
    }


    public void BulletIMG(int mag)
    {
        switch (mag)
        {
            case 0:

                bullet1.SetActive(false);
                bullet2.SetActive(false);
                bullet3.SetActive(false);
                
                break;
            case 1:

                bullet1.SetActive(true);
                bullet2.SetActive(false);
                bullet3.SetActive(false);
                break;
            case 2:
                bullet1.SetActive(true);
                bullet2.SetActive(true);
                bullet3.SetActive(false);
               
                break;
            case 3:
                bullet1.SetActive(true);
                bullet2.SetActive(true);
                bullet3.SetActive(true);
                
                break;
          

        }
    }


    /*public bool ShouldReload()
    {
        return ammoCount == 0 && clipCount > 0;
    }

    public bool IsLowAmmo()
    {
        return ammoCount == 0 && clipCount == 0;
    }

    public void RefillAmmo()
    {
        ammoCount = clipSize;
        clipCount--;
    }*/
}
