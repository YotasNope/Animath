using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AniMathController : MonoBehaviour
{
    public GameObject main;
    private float movementSpeed = 5f;

    [Space(5)]
    [Header("Animaciones Predeterminadas")]
    [Space(20)]
    [SerializeField]
    private bool NewAnimation;
    [SerializeField]
    private bool Idle;
    [SerializeField]
    private bool Walk;
    [SerializeField]
    private bool Running;
    [SerializeField]
    private bool Tired;
    [SerializeField]
    private bool Zombiewalk;

    [Space(5)]
    [Header("Cabeza")]
    [Tooltip("Enparenta el cuello de tu personaje")]
    public GameObject Neck;
    [Tooltip("Enparenta la cabeza de tu personaje")]
    public GameObject Head;
    float yejeN = 0f;
    float xejeN = 0f;
    float zejeN = 0f;

    [Space(5)]
    [Header("Controlador Cabeza")]
    [Range(0, 100)]
    public float AmplitudCuelloY;
    [Range(0, 100)]
    public float AmplitudCuelloX;
    [Range(0, 100)]
    public float AmplitudCuelloZ;
    [Range(-10, 10)]
    public float PuntoInicialCuello;
    [Range(0, 10)]
    public float VelocidadCuelloY;
    [Range(0, 10)]
    public float VelocidadCuelloX;
    [Range(0, 10)]
    public float VelocidadCuelloZ;
    [Range(-50, 50)]
    public float DesfaceCuelloY;
    [Range(150, 230)]
    public float DesfaceCuelloX;
    [Range(145, 218)]
    public float DesfaceCuelloZ;



    [Space(5)]
    [Header("Pierna izquierda")]
    [Tooltip("Enparenta la pierna izquierda de tu personaje")]
    public GameObject LeftHip;
    [Tooltip("Enparenta la rodilla izquierda de tu personaje")]
    public GameObject LeftKnee;
    float xejeLh = 0f;
    float zejeLh = 0f;
    float xejeLk = 0f;
    float zejeLk = 0f;

    [Space(5)]
    [Header("Pierna derecha")]
    [Tooltip("Enparenta la pierna derecha de tu personaje")]
    public GameObject RightHip;
    [Tooltip("Enparenta la rodilla derecha de tu personaje")]
    public GameObject RightKnee;


    float xejeRh = 0f;
    float zejeRh = 0f;
    float xejeRk = 0f;
    float zejeRk = 0f;


    [Space(5)]
    [Header("Controlador Piernas")]
    [Range(0, 100)]
    public float AmplitudPiernasX;
    [Range(0, 100)]
    public float AmplitudPiernasZ;
    [Range(0, 100)]
    public float AmplitudRodillasX;
    [Range(0, 100)]
    public float AmplitudRodillasZ;
    [Range(0, 10)]
    public float VelocidadPiernasX;
    [Range(0, 10)]
    public float VelocidadPiernasZ;
    [Range(0, 10)]
    public float VelocidadRodillasX;
    [Range(0, 10)]
    public float VelocidadRodillasZ;
    [Range(-10, 10)]
    public float PuntoInicialPiernas;
    [Range(-10, 10)]
    public float PuntoInicialRodillas;
    [Range(-50, 50)]
    public float DesfacePiernasX;
    [Range(-50, 50)]
    public float DesfacePiernasZ;
    [Range(-50, 50)]
    public float DesfaceRodillasX;
    [Range(-50, 50)]
    public float DesfaceRodillasZ;




    [Space(5)]
    [Header("Brazo Izquierdo")]
    [Tooltip("Enparenta el hombro izquierdo de tu personaje")]
    public GameObject LeftShoulder;
    [Tooltip("Enparenta el codo izquierdo de tu personaje")]
    public GameObject LeftElbow;
    [Tooltip("Enparenta la muñeca izquierda de tu personaje")]
    public GameObject LeftWrist;

    float yejeLs = 0f;
    float zejeLs = 0f;
    float yejeLe = 0f;
    float zejeLe = 0f;
    float yejeLw = 0f;
    float xejeLw = 0f;

    [Space(5)]
    [Header("Brazo Derecho")]
    [Tooltip("Enparenta el hombro derecho de tu personaje")]
    public GameObject RightShoulder;
    [Tooltip("Enparenta el codo derecho de tu personaje")]
    public GameObject RightElbow;
    [Tooltip("Enparenta la muñeca derecha de tu personaje")]
    public GameObject RightWrist;

    float yejeRs = 0f;
    float zejeRs = 0f;
    float yejeRe = 0f;
    float zejeRe = 0f;
    float yejeRw = 0f;
    float xejeRw = 0f;

    [Space(5)]
    [Header("Controlador Brazos")]
    [Range(0, 100)]
    public float AmplitudHombroY;
    [Range(0, 100)]
    public float AmplitudHombroZ;
    [Range(0, 100)]
    public float AmplitudCodoY;
    [Range(0, 100)]
    public float AmplitudCodoZ;
    [Range(0, 100)]
    public float AmplitudMuñecaY;
    [Range(0, 100)]
    public float AmplitudMuñecaX;
    [Range(0, 10)]
    public float VelocidadHombroY;
    [Range(0, 10)]
    public float VelocidadHombroZ;
    [Range(0, 10)]
    public float VelocidadCodoY;
    [Range(0, 10)]
    public float VelocidadCodoZ;
    [Range(0, 10)]
    public float VelocidadMuñeca;
    [Range(-10, 10)]
    public float PuntoInicialHombroY;
    [Range(-10, 10)]
    public float PuntoInicialHombroZ;
    [Range(-10, 10)]
    public float PuntoInicialCodoY;
    [Range(-10, 10)]
    public float PuntoInicialCodoZ;
    [Range(-10, 10)]
    public float PuntoInicialMuñeca;
    [Range(-100, 100)]
    public float DesfaceHombroY;
    [Range(-100, 100)]
    public float DesfaceHombroZ;
    [Range(-120, 100)]
    public float DesfaceCodoY;
    [Range(-120, 100)]
    public float DesfaceCodoZ;
    [Range(0, 250)]
    public float DesfaceMuñecaY;
    [Range(120, 240)]
    public float DesfaceMuñecaX;
    [Range(-120, 50)]
    public float RotaciónMuñecaZ;


    //Body
    [Space(5)]
    [Header("Pecho")]
    [Tooltip("Enparenta el pecho de tu personaje")]
    public GameObject Chest;
    public GameObject Torax;

    [Header("Controlador Pecho")]
    [Range(0, 50)]
    public float RotaciónPechoY;
    [Range(0, 50)]
    public float RotaciónPechoZ;
    [Range(0, 10)]
    public float VelocidadPecho;
    [Range(-10, 10)]
    public float PuntoInicialPecho;
    [Range(-100, 50)]
    public float DesfacePecho;
    [Range(105, 230)]
    public float RotaciónTorax;


    [Space(5)]
    [Header("Cadera")]
    [Tooltip("Enparenta la cadera de tu personaje")]
    public GameObject Root;


    [Space(5)]
    [Header("Controlador Cadera")]
    [Range(0, 50)]
    public float RotaciónCaderaY;
    [Range(105, 230)]
    public float RotaciónCaderaX;
    [Range(0, 50)]
    public float RotaciónCaderaZ;
    [Range(0f, 10f)]
    public float DesplazamientoCadera;
    [Range(0, 10)]
    public float VelocidadCadera;
    [Range(0, 10)]
    public float VelocidadDesplazamientoCadera;
    [Range(-10, 10)]
    public float PuntoInicialCadera;
    [Range(-10, 10)]
    public float PuntoInicialDesplazamientoCadera;
    [Range(-50, 50)]
    public float DesfaceCadera;
    [Range(-50, 50)]
    public float DesfaceDesplazamientoCadera;




    float yejeR = 0f;
    float xejeR = 0f;
    float pyejeR = 0f;
    float yejeC = 0f;
    float xejeC = 0f;

    float t;



    // Start is called before the first frame update
    void Start()
    {
        if(NewAnimation == true)
        {
            AmplitudCuelloY = 0f;
            AmplitudCuelloX = 0f;
            AmplitudCuelloZ = 0f;
            PuntoInicialCuello = 0f;
            VelocidadCuelloY = 0f;
            VelocidadCuelloX = 0f;
            VelocidadCuelloZ = 0f;
            DesfaceCuelloY = 0f;
            DesfaceCuelloX = 180f;
            DesfaceCuelloZ = 180f;

            AmplitudPiernasX = 0f;
            AmplitudPiernasZ = 0f;
            AmplitudRodillasX = 0f;
            AmplitudRodillasZ = 0f;
            VelocidadPiernasX = 0f;
            VelocidadPiernasZ = 0f;
            VelocidadRodillasX = 0f;
            VelocidadRodillasZ = 0f;
            PuntoInicialPiernas = 0f;
            PuntoInicialRodillas = 0;
            DesfacePiernasX = 0f;
            DesfaceRodillasX = 0f;
            DesfacePiernasZ = 0f;
            DesfaceRodillasZ = 0f;

            AmplitudHombroY = 0f;
            AmplitudHombroZ = 0f;
            AmplitudCodoY = 0f;
            AmplitudCodoZ = 0f;
            AmplitudMuñecaY = 0f;
            AmplitudMuñecaX = 0f;
            RotaciónMuñecaZ = 0f;
            VelocidadHombroY = 0f;
            VelocidadHombroZ = 0f;
            VelocidadCodoY = 0f;
            VelocidadCodoZ = 0f;
            VelocidadMuñeca = 0f;
            PuntoInicialHombroY = 0f;
            PuntoInicialHombroZ = 0f;
            PuntoInicialCodoY = 0f;
            PuntoInicialCodoZ = 0f;
            PuntoInicialMuñeca = 0f;
            DesfaceHombroY = 0f;
            DesfaceHombroZ = 0f;
            DesfaceCodoY = 0f;
            DesfaceCodoZ = 0f;
            DesfaceMuñecaY = 190f;
            DesfaceMuñecaX = 180f;

            RotaciónPechoY = 0f;
            RotaciónPechoZ = 0f;
            VelocidadPecho = 0f;
            PuntoInicialPecho = 0f;
            DesfacePecho = 0f;
            RotaciónTorax = 180f;

            RotaciónCaderaY = 0f;
            RotaciónCaderaZ = 0f;
            RotaciónCaderaX = 180f;
            DesplazamientoCadera = 0f;
            VelocidadCadera = 0f;
            VelocidadDesplazamientoCadera = 0f;
            PuntoInicialCadera = 0f;
            PuntoInicialDesplazamientoCadera = 0f;
            DesfaceCadera = 0f;
        }

        if (NewAnimation == true)
        {
            Idle = false;
            Walk = false;
            Running = false;
            Tired = false;
            Zombiewalk = false;
        }
        else
        {
            Idle = true;
        }

        if (Walk == true)
        {
            Idle = false;
        }

        if (Running == true)
        {
            Idle = false;
        }

        if (Tired == true)
        {
            Idle = false;
        }

        if (Zombiewalk == true)
        {
            Idle = false;
        }

    }

    // Update is called once per frame
    void Update()
    {

        t += 0.1f;


        float verticalInput = Input.GetAxis("Vertical");

        //Head
        yejeN = AmplitudCuelloY * Mathf.Sin((VelocidadCuelloY * t) - PuntoInicialCuello) + DesfaceCuelloY;
        xejeN = AmplitudCuelloX * Mathf.Sin((VelocidadCuelloX * t) - PuntoInicialCuello) + DesfaceCuelloX;
        zejeN = AmplitudCuelloZ * Mathf.Sin((VelocidadCuelloZ * t) - PuntoInicialCuello) + DesfaceCuelloZ;

        Neck.transform.rotation = Quaternion.Euler(xejeN, yejeN, zejeN);

        //LeftLeg
        xejeLh = -AmplitudPiernasX * Mathf.Sin((VelocidadPiernasX * t) - PuntoInicialPiernas) + DesfacePiernasX;
        zejeLh = AmplitudPiernasZ * Mathf.Sin((VelocidadPiernasZ * t) - PuntoInicialPiernas) + DesfacePiernasZ;
        xejeLk = AmplitudRodillasX * Mathf.Cos((VelocidadRodillasX * t) - PuntoInicialRodillas) + DesfaceRodillasX;
        zejeLk = AmplitudRodillasZ * Mathf.Cos((VelocidadRodillasZ * t) - PuntoInicialRodillas) + DesfaceRodillasZ;

        LeftHip.transform.rotation = Quaternion.Euler(xejeLh, -180, -zejeLh);
        LeftKnee.transform.rotation = Quaternion.Euler(xejeLk, -180, zejeLk);

        //RightLeg
        xejeRh = AmplitudPiernasX * Mathf.Sin((VelocidadPiernasX * t) + PuntoInicialPiernas) + DesfacePiernasX;
        zejeRh = AmplitudPiernasZ * Mathf.Sin((VelocidadPiernasZ * t) - PuntoInicialPiernas) + DesfacePiernasZ;
        xejeRk = -AmplitudRodillasX * Mathf.Cos((VelocidadRodillasX * t) + PuntoInicialRodillas) + DesfaceRodillasX;
        zejeRk = AmplitudRodillasZ * Mathf.Cos((VelocidadRodillasZ * t) - PuntoInicialRodillas) + DesfaceRodillasZ;

        RightHip.transform.rotation = Quaternion.Euler(xejeRh, 180, -zejeRh);
        RightKnee.transform.rotation = Quaternion.Euler(xejeRk, 180, zejeRk);

        //LeftArm
        yejeLs = AmplitudHombroY * Mathf.Sin((VelocidadHombroY * t) - PuntoInicialHombroY) + DesfaceHombroY;
        zejeLs = AmplitudHombroZ * Mathf.Sin((VelocidadHombroZ * t) - PuntoInicialHombroZ) + DesfaceHombroZ;

        yejeLe = -AmplitudCodoY * Mathf.Cos((VelocidadCodoY * t) + PuntoInicialCodoY) + DesfaceCodoY;
        zejeLe = -AmplitudCodoZ * Mathf.Cos((VelocidadCodoZ * t) + PuntoInicialCodoZ) + DesfaceCodoZ;

        yejeLw = AmplitudMuñecaY * Mathf.Sin((VelocidadMuñeca * t) - PuntoInicialMuñeca) - DesfaceMuñecaY;
        xejeLw = -AmplitudMuñecaX * Mathf.Sin((VelocidadMuñeca * t) - PuntoInicialMuñeca) + DesfaceMuñecaX;


        //RightArm
        yejeRs = -AmplitudHombroY * Mathf.Sin((VelocidadHombroY * t) - PuntoInicialHombroY) + DesfaceHombroY;
        zejeRs = -AmplitudHombroZ * Mathf.Sin((VelocidadHombroZ * t) - PuntoInicialHombroZ) + DesfaceHombroZ;

        yejeRe = AmplitudCodoY * Mathf.Cos((VelocidadCodoY * t) + PuntoInicialCodoY) + DesfaceCodoY;
        zejeRe = AmplitudCodoZ * Mathf.Cos((VelocidadCodoZ * t) + PuntoInicialCodoZ) + DesfaceCodoZ;

        yejeRw = AmplitudMuñecaY * Mathf.Sin((VelocidadMuñeca * t) - PuntoInicialMuñeca) + DesfaceMuñecaY;
        xejeRw = AmplitudMuñecaX * Mathf.Sin((VelocidadMuñeca * t) - PuntoInicialMuñeca) + DesfaceMuñecaX;

        LeftShoulder.transform.rotation = Quaternion.Euler(yejeLs, 180, -zejeLs);
        RightShoulder.transform.rotation = Quaternion.Euler(yejeRs, 180, zejeRs);

        LeftElbow.transform.rotation = Quaternion.Euler(yejeLe, 180, -zejeLe);
        RightElbow.transform.rotation = Quaternion.Euler(yejeRe, 180, zejeRe);

        LeftWrist.transform.rotation = Quaternion.Euler(xejeLw, -RotaciónMuñecaZ, yejeLw);
        RightWrist.transform.rotation = Quaternion.Euler(xejeRw, RotaciónMuñecaZ, yejeRw);

        //Chest
        yejeC = -RotaciónPechoY * Mathf.Sin((VelocidadPecho * t) - PuntoInicialPecho) + DesfacePecho;
        xejeC = RotaciónPechoZ * Mathf.Sin((VelocidadPecho * t) - PuntoInicialPecho) + 180;
        Chest.transform.rotation = Quaternion.Euler(RotaciónTorax, yejeC, xejeC);
        Torax.transform.rotation = Quaternion.Euler(RotaciónTorax, 0, -180);

        //Root
        yejeR = RotaciónCaderaY * Mathf.Sin((VelocidadCadera * t) - PuntoInicialCadera) + DesfaceCadera;
        xejeR = -RotaciónCaderaZ * Mathf.Sin((VelocidadCadera * t) - PuntoInicialCadera) + 180;
        pyejeR = DesplazamientoCadera * Mathf.Sin((VelocidadDesplazamientoCadera * t) + PuntoInicialDesplazamientoCadera) + DesfaceDesplazamientoCadera;

        Root.transform.rotation = Quaternion.Euler(RotaciónCaderaX, yejeR, xejeR);
        Root.transform.position = transform.position + new Vector3(0, pyejeR, 0);
        main.transform.position = transform.position + new Vector3(0, 0, verticalInput * -movementSpeed * Time.deltaTime);

        if (Walk == true)
        {
            walk();
        }

        if (Running == true)
        {
            run();
        }

        if (Tired == true)
        {
            tired();
        }

        if (Zombiewalk == true)
        {
            zombiewalk();
        }

        if (Idle == true)
        {
            idle();
        }
    }

    void walk()
    {
        AmplitudCuelloY = 2f;
        AmplitudCuelloX = 0.5f;
        AmplitudCuelloZ = 0.5f;
        PuntoInicialCuello = 0f;
        VelocidadCuelloY = 0.4f;
        VelocidadCuelloX = 0.8f;
        VelocidadCuelloZ = 0.4f;
        DesfaceCuelloY = 0f;
        DesfaceCuelloX = 177f;
        DesfaceCuelloZ = 180f;

        AmplitudPiernasX = 24f;
        AmplitudPiernasZ = 0f;
        AmplitudRodillasX = 20f;
        AmplitudRodillasZ = 0f;
        VelocidadPiernasX = 0.4f;
        VelocidadPiernasZ = 0.4f;
        VelocidadRodillasX = 0.4f;
        VelocidadRodillasZ = 0.4f;
        PuntoInicialPiernas = 0f;
        PuntoInicialRodillas = 0;
        DesfacePiernasX = -1.3f;
        DesfaceRodillasX = 18f;
        DesfacePiernasZ = 0f;
        DesfaceRodillasZ = 0f;

        AmplitudHombroY = 15.7f;
        AmplitudHombroZ = 2f;
        AmplitudCodoY = 20f;
        AmplitudCodoZ = 1f;
        AmplitudMuñecaY = 10.4f;
        AmplitudMuñecaX = 25f;
        RotaciónMuñecaZ = -7f;
        VelocidadHombroY = 0.4f;
        VelocidadHombroZ = 0.4f;
        VelocidadCodoY = 0.4f;
        VelocidadCodoZ = 0.4f;
        VelocidadMuñeca = 0.4f;
        PuntoInicialHombroY = 0f;
        PuntoInicialHombroZ = 0f;
        PuntoInicialCodoY = 1f;
        PuntoInicialCodoZ = 0f;
        PuntoInicialMuñeca = 0f;
        DesfaceHombroY = 0f;
        DesfaceHombroZ = -77f;
        DesfaceCodoY = -20f;
        DesfaceCodoZ = -82f;
        DesfaceMuñecaY = 100f;
        DesfaceMuñecaX = 190f;

        RotaciónPechoY = 9.1f;
        RotaciónPechoZ = 0.5f;
        VelocidadPecho = 0.4f;
        PuntoInicialPecho = 0f;
        DesfacePecho = 0f;
        RotaciónTorax = 170f;

        RotaciónCaderaY = 5f;
        RotaciónCaderaZ = 2.5f;
        RotaciónCaderaX = 185f;
        DesplazamientoCadera = 0.015f;
        VelocidadCadera = 0.4f;
        VelocidadDesplazamientoCadera = 0.8f;
        PuntoInicialCadera = 0f;
        PuntoInicialDesplazamientoCadera = 0f;
        DesfaceCadera = 0f;

    }

    void run()
    {
        AmplitudCuelloY = 3f;
        AmplitudCuelloX = 0.5f;
        AmplitudCuelloZ = 1f;
        PuntoInicialCuello = 0f;
        VelocidadCuelloY = 0.6f;
        VelocidadCuelloX = 1.2f;
        VelocidadCuelloZ = 0.6f;
        DesfaceCuelloY = 0f;
        DesfaceCuelloX = 157.7f;
        DesfaceCuelloZ = 180f;

        AmplitudPiernasX = 45f;
        AmplitudPiernasZ = 2f;
        AmplitudRodillasX = 45f;
        AmplitudRodillasZ = 2f;
        VelocidadPiernasX = 0.6f;
        VelocidadPiernasZ = 0.6f;
        VelocidadRodillasX = 0.6f;
        VelocidadRodillasZ = 0.6f;
        PuntoInicialPiernas = 0f;
        PuntoInicialRodillas = 0;
        DesfacePiernasX = 1.3f;
        DesfaceRodillasX = 38f;
        DesfacePiernasZ = 0f;
        DesfaceRodillasZ = 0f;

        AmplitudHombroY = 45f;
        AmplitudHombroZ = 3.6f;
        AmplitudCodoY = 70f;
        AmplitudCodoZ = 32f;
        AmplitudMuñecaY = 7.3f;
        AmplitudMuñecaX = 60f;
        RotaciónMuñecaZ = -36f;
        VelocidadHombroY = 0.6f;
        VelocidadHombroZ = 0.6f;
        VelocidadCodoY = 0.6f;
        VelocidadCodoZ = 0.6f;
        VelocidadMuñeca = 0.6f;
        PuntoInicialHombroY = 0f;
        PuntoInicialHombroZ = 0f;
        PuntoInicialCodoY = 1f;
        PuntoInicialCodoZ = 1.3f;
        PuntoInicialMuñeca = 1f;
        DesfaceHombroY = 24f;
        DesfaceHombroZ = -70f;
        DesfaceCodoY = -50f;
        DesfaceCodoZ = -100f;
        DesfaceMuñecaY = 115.8f;
        DesfaceMuñecaX = 240f;

        RotaciónPechoY = 15f;
        RotaciónPechoZ = 1f;
        VelocidadPecho = 0.6f;
        PuntoInicialPecho = 0f;
        DesfacePecho = 0f;
        RotaciónTorax = 157.4f;

        RotaciónCaderaY = 10f;
        RotaciónCaderaZ = 1f;
        RotaciónCaderaX = 165f;
        DesplazamientoCadera = 0.025f;
        VelocidadCadera = 0.6f;
        VelocidadDesplazamientoCadera = 1.2f;
        PuntoInicialCadera = 0f;
        PuntoInicialDesplazamientoCadera = 0f;
        DesfaceCadera = 0f;
    }

    void tired()
    {
        AmplitudCuelloY = 0f;
        AmplitudCuelloX = 1f;
        AmplitudCuelloZ = 2f;
        PuntoInicialCuello = -2.5f;
        VelocidadCuelloY = 0.3f;
        VelocidadCuelloX = 0.6f;
        VelocidadCuelloZ = 0.3f;
        DesfaceCuelloY = 0f;
        DesfaceCuelloX = 158f;
        DesfaceCuelloZ = 180f;

        AmplitudPiernasX = 20f;
        AmplitudPiernasZ = 1f;
        AmplitudRodillasX = 19f;
        AmplitudRodillasZ = 2f;
        VelocidadPiernasX = 0.3f;
        VelocidadPiernasZ = 0.3f;
        VelocidadRodillasX = 0.3f;
        VelocidadRodillasZ = 0.3f;
        PuntoInicialPiernas = 0f;
        PuntoInicialRodillas = 0f;
        DesfacePiernasX = 0f;
        DesfaceRodillasX = 15f;
        DesfacePiernasZ = 0f;
        DesfaceRodillasZ = 0f;

        AmplitudHombroY = 5f;
        AmplitudHombroZ = 7f;
        AmplitudCodoY = 5f;
        AmplitudCodoZ = 7f;
        AmplitudMuñecaY = 6.6f;
        AmplitudMuñecaX = 9f;
        RotaciónMuñecaZ = -50f;
        VelocidadHombroY = 0.3f;
        VelocidadHombroZ = 0.3f;
        VelocidadCodoY = 0.3f;
        VelocidadCodoZ = 0.3f;
        VelocidadMuñeca = 0.3f;
        PuntoInicialHombroY = 0f;
        PuntoInicialHombroZ = 0f;
        PuntoInicialCodoY = 0f;
        PuntoInicialCodoZ = 0.5f;
        PuntoInicialMuñeca = 2f;
        DesfaceHombroY = 4.5f;
        DesfaceHombroZ = -80f;
        DesfaceCodoY = -11f;
        DesfaceCodoZ = -90f;
        DesfaceMuñecaY = 100f;
        DesfaceMuñecaX = 180f;

        RotaciónPechoY = 5f;
        RotaciónPechoZ = 0f;
        VelocidadPecho = 0.3f;
        PuntoInicialPecho = 0f;
        DesfacePecho = 0f;
        RotaciónTorax = 131f;

        RotaciónCaderaY = 5f;
        RotaciónCaderaZ = 1f;
        RotaciónCaderaX = 180f;
        DesplazamientoCadera = 0.015f;
        VelocidadCadera = 0.3f;
        VelocidadDesplazamientoCadera = 0.6f;
        PuntoInicialCadera = 0f;
        PuntoInicialDesplazamientoCadera = 0f;
        DesfaceCadera = 0f;
    }
    
    void zombiewalk()
    {
        AmplitudCuelloY = 1.2f;
        AmplitudCuelloX = 4.9f;
        AmplitudCuelloZ = 0f;
        PuntoInicialCuello = 0f;
        VelocidadCuelloY = 0.2f;
        VelocidadCuelloX = 0.2f;
        VelocidadCuelloZ = 0.2f;
        DesfaceCuelloY = 0f;
        DesfaceCuelloX = 193f;
        DesfaceCuelloZ = 156.3f;

        AmplitudPiernasX = 15f;
        AmplitudPiernasZ = 1f;
        AmplitudRodillasX = 22.8f;
        AmplitudRodillasZ = 2f;
        VelocidadPiernasX = 0.2f;
        VelocidadPiernasZ = 0.2f;
        VelocidadRodillasX = 0.2f;
        VelocidadRodillasZ = 0.2f;
        PuntoInicialPiernas = 0f;
        PuntoInicialRodillas = 0f;
        DesfacePiernasX = 0f;
        DesfaceRodillasX = 20f;
        DesfacePiernasZ = 0f;
        DesfaceRodillasZ = 0f;

        AmplitudHombroY = 4f;
        AmplitudHombroZ = 3f;
        AmplitudCodoY = 2f;
        AmplitudCodoZ = 5f;
        AmplitudMuñecaY = 5f;
        AmplitudMuñecaX = 12.5f;
        RotaciónMuñecaZ = -90f;
        VelocidadHombroY = 0.2f;
        VelocidadHombroZ = 0.2f;
        VelocidadCodoY = 0.2f;
        VelocidadCodoZ = 0.2f;
        VelocidadMuñeca = 0.2f;
        PuntoInicialHombroY = 0f;
        PuntoInicialHombroZ = 0f;
        PuntoInicialCodoY = 0f;
        PuntoInicialCodoZ = 0f;
        PuntoInicialMuñeca = 0.3f;
        DesfaceHombroY = -64f;
        DesfaceHombroZ = -73.8f;
        DesfaceCodoY = 79f;
        DesfaceCodoZ = 100f;
        DesfaceMuñecaY = 199f;
        DesfaceMuñecaX = 180f;

        RotaciónPechoY = 3f;
        RotaciónPechoZ = 3f;
        VelocidadPecho = 0.2f;
        PuntoInicialPecho = 0f;
        DesfacePecho = 0f;
        RotaciónTorax = 135f;

        RotaciónCaderaY = 1f;
        RotaciónCaderaZ = 1f;
        RotaciónCaderaX = 172.6f;
        DesplazamientoCadera = 0.015f;
        VelocidadCadera = 0.2f;
        VelocidadDesplazamientoCadera = 0.4f;
        PuntoInicialCadera = 0f;
        PuntoInicialDesplazamientoCadera = 0f;
        DesfaceCadera = 0f;
    }

    void idle()
    {
        AmplitudCuelloY = 10f;
        AmplitudCuelloX = 0.2f;
        AmplitudCuelloZ = 0.5f;
        PuntoInicialCuello = 0f;
        VelocidadCuelloY = 0.02f;
        VelocidadCuelloX = 0.1f;
        VelocidadCuelloZ = 0.1f;
        DesfaceCuelloY = 0f;
        DesfaceCuelloX = 177f;
        DesfaceCuelloZ = 180f;

        AmplitudPiernasX = 0.1f;
        AmplitudPiernasZ = 0f;
        AmplitudRodillasX =0.1f;
        AmplitudRodillasZ = 0f;
        VelocidadPiernasX = 0.2f;
        VelocidadPiernasZ = 0.2f;
        VelocidadRodillasX = 0.2f;
        VelocidadRodillasZ = 0.2f;
        PuntoInicialPiernas = 0f;
        PuntoInicialRodillas = 0f;
        DesfacePiernasX = -2.8f;
        DesfaceRodillasX = 0f;
        DesfacePiernasZ = 0f;
        DesfaceRodillasZ = 0f;

        AmplitudHombroY = 0.3f;
        AmplitudHombroZ = 0.3f;
        AmplitudCodoY = 0.3f;
        AmplitudCodoZ = 0.3f;
        AmplitudMuñecaY = 1f;
        AmplitudMuñecaX = 1f;
        RotaciónMuñecaZ = 0f;
        VelocidadHombroY = 0.2f;
        VelocidadHombroZ = 0.2f;
        VelocidadCodoY = 0.2f;
        VelocidadCodoZ = 0.2f;
        VelocidadMuñeca = 0.2f;
        PuntoInicialHombroY = 0f;
        PuntoInicialHombroZ = 0f;
        PuntoInicialCodoY = 0f;
        PuntoInicialCodoZ = 0f;
        PuntoInicialMuñeca = 0f;
        DesfaceHombroY = 8f;
        DesfaceHombroZ = -77f;
        DesfaceCodoY = -13f;
        DesfaceCodoZ = -80f;
        DesfaceMuñecaY = 100f;
        DesfaceMuñecaX = 180f;

        RotaciónPechoY = 0.5f;
        RotaciónPechoZ = 0.5f;
        VelocidadPecho = 0.1f;
        PuntoInicialPecho = 0f;
        DesfacePecho = 0f;
        RotaciónTorax = 170f;

        RotaciónCaderaY = 0.2f;
        RotaciónCaderaZ = 0.2f;
        RotaciónCaderaX = 180f;
        DesplazamientoCadera = 0f;
        VelocidadCadera = 0.2f;
        VelocidadDesplazamientoCadera = 0f;
        PuntoInicialCadera = 0f;
        PuntoInicialDesplazamientoCadera = 0f;
        DesfaceCadera = 0f;
    }

}
