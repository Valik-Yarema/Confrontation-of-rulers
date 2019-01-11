using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ShipController : MonoBehaviour
{


    public GameObject _Island;
    public GameObject _Home;
    public int _capacity = 0;

    public int _CapacitySize = 50;

    [Range(0, 10)]
    public float _Spead;
    public bool _GoToIsland = true;
    private Transform _SelTransform;



    private NavMeshAgent agent;
    // Use this for initialization
    void Start()
    {
      //  moving(_Island); 
        _SelTransform = GetComponent<Transform>();
        //  recours.Recours_Capacity[0] = 0;
    }

    // Update is called once per frame
    void Update()
    {if (_GoToIsland)
        {
            _SelTransform.position = Vector3.MoveTowards(_SelTransform.position, _Island.transform.position, _Spead * Time.deltaTime);
            if (_SelTransform.position == _Island.transform.position)
            {
                RecourseMoveToShip();
            }
        }

        else
        {
            if (_SelTransform.position == _Home.transform.position)
            {
                RecourseMoveToHome();
            }
            _SelTransform.position = Vector3.MoveTowards(_SelTransform.position, _Home.transform.position, _Spead * Time.deltaTime);
           
        }

    }
    public void moving(GameObject _target)
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(_target.transform.position);
    }
    public void RecourseMoveToShip()
    {
      //  moving(_Home);
        _SelTransform.position = Vector3.MoveTowards(_SelTransform.position, _Island.transform.position, _Spead * Time.deltaTime);


        _GoToIsland = false;
        _capacity = _Island.gameObject.GetComponent<IslandController>().wood;         // wood замiнити на  reсours і доробити в IslandControler
                                                                                      //забираємо ресурс і зменшуємо його кількість на острові
        if (_capacity - _CapacitySize >= 0)
        {
            _Island.gameObject.GetComponent<IslandController>().wood -= _CapacitySize;
            _capacity = _CapacitySize;
        }
        //якщо ресурсів на острові менше ніж місткість корабляяя забираємо всі
        else
        {
            _capacity = _Island.gameObject.GetComponent<IslandController>().wood;
            _Island.gameObject.GetComponent<IslandController>().wood = 0;

        }

    }
    public void RecourseMoveToHome()
    {
      // moving(_Island);
          
        if (_SelTransform.position == _Home.transform.position)
        {
            _GoToIsland = true;
            _Home.gameObject.GetComponent<PlayerController>().wood += _capacity;
            _capacity = 0;
            //приплив на острів відвантажив , доробити
        }
    }
}


