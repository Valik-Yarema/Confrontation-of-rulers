using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class ShipNavMController : MonoBehaviour
{


    public GameObject _Target;
    public GameObject _Home;
    public int _capacity = 0;

    public string name_transfer_res;

    public int _CapacitySize = 50;

    [Range(0, 10)]
    public float Spead;

    private bool _GoToIsland = true;
    private Transform _SelTransform;
    private bool Start_Move_Ship = false;

    public bool Targ_Trig = false;
    public bool This_Ship_Select = false;

    private Vector3 position1;
    private NavMeshAgent agent;
    // Use this for initialization
    void Start()
    {
       
        _Target.transform.position=transform.position;
       // agent.speed = _Spead;

      
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<NavMeshAgent>().speed = Spead;
        This_Ship_Select = GetComponent<Object_Select>().This_Object_Select;
        if (Start_Move_Ship)
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

        if ((Input.GetMouseButtonDown(0))&&(This_Ship_Select)) go(); 
       
    }

    private void go()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            position1 = hit.point;         
            position1.y = 0;
            if (hit.collider.gameObject.tag == "Home")
            {
               GetComponent<ShipNavMController>()._Home = hit.collider.gameObject;//для вибору точки кударесурси звозити
               
            }

            /*if(hit.collider.gameObject.tag == "Island")
            {
                GetComponent<ShipNavMController>()._Target = hit.collider.gameObject;

            }*/
        }
        
        GetComponent<ShipNavMController>()._Target.GetComponent<Transform>().position = position1;
        GetComponent<ShipNavMController>().Start_Move_Ship = true;
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
                other.gameObject.GetComponent<Island_Type>().Island_Type_res.res_cap -= _CapacitySize;//забираємо ресурс і зменшуємо його кількість на острові
                _capacity = _CapacitySize;
            }
            //якщо ресурсів на острові менше ніж місткість корабляяя забираємо всі
            else
            {
                _capacity = other.gameObject.GetComponent<Island_Type>().Island_Type_res.res_cap;
                other.gameObject.GetComponent<Island_Type>().Island_Type_res.res_cap = 0;
            
                                                                          
            }
        
        _GoToIsland = false;

     
       

    }
    public void RecourseMoveToHome()
    {  for(int i=0;i< ResPlayer.Res .Count; i++)
        {
            if(name_transfer_res==ResPlayer.NameRes[i])
            {
                ResPlayer.Res[i] += _capacity;
            }
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


