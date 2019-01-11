using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ShipNavMController : MonoBehaviour
{


    public GameObject _Island;
    public GameObject _Home;
    public int _capacity = 0;

    public int _CapacitySize = 50;

    [Range(0, 10)]
    public float _Spead;
    public bool _GoToIsland = true;
    private Transform _SelTransform;

    public bool _Test = false;


    private NavMeshAgent agent;
    // Use this for initialization
    void Start()
    {
        //  moving(_Island); 

        //  recours.Recours_Capacity[0] = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (_Test)
        {
            RecourseMoveToShip();
            _Test = false;
        }
        else
        {
            _Home.gameObject.GetComponent<PlayerController>().wood += _capacity;
            _capacity = 0;

        }
        if (_GoToIsland)
        {
            moving(_Island);



        }

        else
        {

            moving(_Home);
        }

    }
    public void moving(GameObject _target)
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(_target.transform.position);
    }
    public void RecourseMoveToShip()
    {
        _capacity = _Island.gameObject.GetComponent<IslandController>().wood;                                                       // wood замiнити на  reсours і доробити в IslandControler
        _Home.gameObject.GetComponent<PlayerController>().stone += 1;
        if (_capacity == 0)
        {
            if (_capacity - _CapacitySize >= 0)
            {
                _Island.gameObject.GetComponent<IslandController>().wood -= _CapacitySize;//забираємо ресурс і зменшуємо його кількість на острові
                _capacity = _CapacitySize;
            }
            //якщо ресурсів на острові менше ніж місткість корабляяя забираємо всі
            else
            {
                _capacity = _Island.gameObject.GetComponent<IslandController>().wood;
                _Island.gameObject.GetComponent<IslandController>().wood = 0;

            }
        }
        _GoToIsland = false;

    }
    public void RecourseMoveToHome()
    {
        _Home.gameObject.GetComponent<PlayerController>().wood += _capacity;
        _capacity = 0;
       
        _GoToIsland = true;
        //приплив на острів відвантажив , доробити

    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Island"))
        {
            RecourseMoveToShip();
            _Home.gameObject.GetComponent<PlayerController>().gold += 1;

        }
        if (other.CompareTag("Home"))
        {

            RecourseMoveToHome();
        }
    }
    
}


