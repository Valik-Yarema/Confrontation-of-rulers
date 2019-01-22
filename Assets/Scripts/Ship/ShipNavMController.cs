using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ShipNavMController : MonoBehaviour
{


    public GameObject _Target;
    public GameObject _Home;
    public int _capacity = 0;

    public string name_transfer_res;

    public int _CapacitySize = 50;

    [Range(0, 10)]
    public float _Spead;

    private bool _GoToIsland = true;
    private Transform _SelTransform;

    public bool _StartShip = false;
    public bool Targ_Trig = false;
    
    private NavMeshAgent agent;
    // Use this for initialization
    void Start()
    {
        _Target.transform.position=transform.position;
       // agent.speed = _Spead;

      
    }

    // Update is called once per frame
    void Update()
    {   if(_StartShip)
        {

            if (_GoToIsland)
            {
                moving(_Target);
            }

            else
            {

                moving(_Home);
            }

        }
    }
    public void moving(GameObject _target)
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(_target.transform.position);
    }
    public void RecourseMoveToShip(GameObject other)
    {
        name_transfer_res = other.gameObject.GetComponent<Island_Type>().Island_Type_res.NameR;


            if (other.gameObject.GetComponent<Island_Type>().Island_Type_res.res_cap- _CapacitySize >= 0)
            {
                //_Home.gameObject.GetComponent<PlayerController>().gold+= 1;//test

                other.gameObject.GetComponent<Island_Type>().Island_Type_res.res_cap -= _CapacitySize;//забираємо ресурс і зменшуємо його кількість на острові
                _capacity = _CapacitySize;
            }
            //якщо ресурсів на острові менше ніж місткість корабляяя забираємо всі
            else
            {
                _capacity = other.gameObject.GetComponent<Island_Type>().Island_Type_res.res_cap;
                other.gameObject.GetComponent<Island_Type>().Island_Type_res.res_cap = 0;
                //_Home.gameObject.GetComponent<PlayerController>().stone += 1;//test
                                                                          
            }
        
        _GoToIsland = false;

     
       // _Island.gameObject.GetComponent<IslandController>().wood -= _capacity;

    }
    public void RecourseMoveToHome()
    {
        //можливо потім переробити вивантаження ресурсів
        switch (name_transfer_res)
        {
            case "wood" : _Home.gameObject.GetComponentInParent<PlayerController>().wood += _capacity; break;
            case "stone": _Home.gameObject.GetComponentInParent<PlayerController>().stone += _capacity; break;
            case "iron" : _Home.gameObject.GetComponentInParent<PlayerController >().iron+= _capacity; break;
            case "gold" : _Home.gameObject.GetComponentInParent<PlayerController >().gold += _capacity; break;
            default:  break;
        }

        
        _capacity = 0;
       
        _GoToIsland = true;
        //приплив на острів відвантажив , доробити

    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Island"))//&&(Targ_Trig))
        {
            RecourseMoveToShip(other.gameObject);
         

        }
      
        if (other.CompareTag("Home"))
        {

            RecourseMoveToHome();
        }

    }

}


