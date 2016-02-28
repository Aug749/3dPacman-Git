using UnityEngine;
using System.Collections;

public class Ghost : MonoBehaviour {

    private Vector3 speed;
    private bool checkN, checkS, checkE, checkW;
    private string dir;
    public GameObject Pac;
    public GameObject GridAccess;
    Grid grid;
    
    float velocity = .01f;

    // Use this for initialization
    void Start () {
        speed = new Vector3(-velocity, 0, 0);

        checkN = false;
        checkS = false;
        checkE = false;
        checkW = false;

        dir = "west";
        grid = GridAccess.GetComponent<Grid>();
    }

    // Update is called once per frame
    void Update ()
    {
        CalculateTurn();

        transform.position += velocity *speed;
    }

    void CalculateTurn()
    {
        if (dir == "north" && ((grid.loc_to_grid_x(transform.position.x) == 0 && grid.loc_to_grid_z(transform.position.z) == 0) || (grid.loc_to_grid_x(transform.position.x) == 14 && grid.loc_to_grid_z(transform.position.z) == 0) || (grid.loc_to_grid_x(transform.position.x) == 14 && grid.loc_to_grid_z(transform.position.z) == 7) || (grid.loc_to_grid_x(transform.position.x) == 8 && grid.loc_to_grid_z(transform.position.z) == 10) || (grid.loc_to_grid_x(transform.position.x) == 0 && grid.loc_to_grid_z(transform.position.z) == 19) || (grid.loc_to_grid_x(transform.position.x) == 14 && grid.loc_to_grid_z(transform.position.z) == 19) || (grid.loc_to_grid_x(transform.position.x) == 23 && grid.loc_to_grid_z(transform.position.z) == 22) || (grid.loc_to_grid_x(transform.position.x) == 0 && grid.loc_to_grid_z(transform.position.z) == 25) || (grid.loc_to_grid_x(transform.position.x) == 14 && grid.loc_to_grid_z(transform.position.z) == 25)))
            checkE = true;
        else if (dir == "south" && ((grid.loc_to_grid_x(transform.position.x) == 0 && grid.loc_to_grid_z(transform.position.z) == 28) || (grid.loc_to_grid_x(transform.position.x) == 8 && grid.loc_to_grid_z(transform.position.z) == 25) || (grid.loc_to_grid_x(transform.position.x) == 20 && grid.loc_to_grid_z(transform.position.z) == 25) || (grid.loc_to_grid_x(transform.position.x) == 0 && grid.loc_to_grid_z(transform.position.z) == 22) || (grid.loc_to_grid_x(transform.position.x) == 0 && grid.loc_to_grid_z(transform.position.z) == 7) || (grid.loc_to_grid_x(transform.position.x) == 8 && grid.loc_to_grid_z(transform.position.z) == 7)))
            checkE = true;

        else if (dir == "north" && ((grid.loc_to_grid_x(transform.position.x) == 25 && grid.loc_to_grid_z(transform.position.z) == 0) || (grid.loc_to_grid_x(transform.position.x) == 11 && grid.loc_to_grid_z(transform.position.z) == 0) || (grid.loc_to_grid_x(transform.position.x) == 11 && grid.loc_to_grid_z(transform.position.z) == 7) || (grid.loc_to_grid_x(transform.position.x) == 17 && grid.loc_to_grid_z(transform.position.z) == 10) || (grid.loc_to_grid_x(transform.position.x) == 25 && grid.loc_to_grid_z(transform.position.z) == 19) || (grid.loc_to_grid_x(transform.position.x) == 11 && grid.loc_to_grid_z(transform.position.z) == 19) || (grid.loc_to_grid_x(transform.position.x) == 2 && grid.loc_to_grid_z(transform.position.z) == 22) || (grid.loc_to_grid_x(transform.position.x) == 25 && grid.loc_to_grid_z(transform.position.z) == 25) || (grid.loc_to_grid_x(transform.position.x) == 11 && grid.loc_to_grid_z(transform.position.z) == 25)))
            checkW = true;
        else if (dir == "south" && ((grid.loc_to_grid_x(transform.position.x) == 25 && grid.loc_to_grid_z(transform.position.z) == 28) || (grid.loc_to_grid_x(transform.position.x) == 5 && grid.loc_to_grid_z(transform.position.z) == 23) || (grid.loc_to_grid_x(transform.position.x) == 17 && grid.loc_to_grid_z(transform.position.z) == 25) || (grid.loc_to_grid_x(transform.position.x) == 25 && grid.loc_to_grid_z(transform.position.z) == 22) || (grid.loc_to_grid_x(transform.position.x) == 17 && grid.loc_to_grid_z(transform.position.z) == 7) || (grid.loc_to_grid_x(transform.position.x) == 25 && grid.loc_to_grid_z(transform.position.z) == 7)))
            checkW = true;

        else if (dir == "east" && ((grid.loc_to_grid_x(transform.position.x) == 0 && grid.loc_to_grid_z(transform.position.z) == 0) || (grid.loc_to_grid_x(transform.position.x) == 14 && grid.loc_to_grid_z(transform.position.z) == 0) || (grid.loc_to_grid_x(transform.position.x) == 14 && grid.loc_to_grid_z(transform.position.z) == 7) || (grid.loc_to_grid_x(transform.position.x) == 8 && grid.loc_to_grid_z(transform.position.z) == 10) || (grid.loc_to_grid_x(transform.position.x) == 0 && grid.loc_to_grid_z(transform.position.z) == 19) || (grid.loc_to_grid_x(transform.position.x) == 14 && grid.loc_to_grid_z(transform.position.z) == 19) || (grid.loc_to_grid_x(transform.position.x) == 23 && grid.loc_to_grid_z(transform.position.z) == 22) || (grid.loc_to_grid_x(transform.position.x) == 0 && grid.loc_to_grid_z(transform.position.z) == 25) || (grid.loc_to_grid_x(transform.position.x) == 14 && grid.loc_to_grid_z(transform.position.z) == 25)))
            checkN = true;
        else if (dir == "west" && ((grid.loc_to_grid_x(transform.position.x) == 25 && grid.loc_to_grid_z(transform.position.z) == 0) || (grid.loc_to_grid_x(transform.position.x) == 11 && grid.loc_to_grid_z(transform.position.z) == 0) || (grid.loc_to_grid_x(transform.position.x) == 11 && grid.loc_to_grid_z(transform.position.z) == 7) || (grid.loc_to_grid_x(transform.position.x) == 17 && grid.loc_to_grid_z(transform.position.z) == 10) || (grid.loc_to_grid_x(transform.position.x) == 25 && grid.loc_to_grid_z(transform.position.z) == 19) || (grid.loc_to_grid_x(transform.position.x) == 11 && grid.loc_to_grid_z(transform.position.z) == 19) || (grid.loc_to_grid_x(transform.position.x) == 2 && grid.loc_to_grid_z(transform.position.z) == 22) || (grid.loc_to_grid_x(transform.position.x) == 25 && grid.loc_to_grid_z(transform.position.z) == 25) || (grid.loc_to_grid_x(transform.position.x) == 11 && grid.loc_to_grid_z(transform.position.z) == 25)))
            checkN = true;

        else if (dir == "east" && ((grid.loc_to_grid_x(transform.position.x) == 0 && grid.loc_to_grid_z(transform.position.z) == 28) || (grid.loc_to_grid_x(transform.position.x) == 8 && grid.loc_to_grid_z(transform.position.z) == 25) || (grid.loc_to_grid_x(transform.position.x) == 20 && grid.loc_to_grid_z(transform.position.z) == 25) || (grid.loc_to_grid_x(transform.position.x) == 0 && grid.loc_to_grid_z(transform.position.z) == 22) || (grid.loc_to_grid_x(transform.position.x) == 0 && grid.loc_to_grid_z(transform.position.z) == 7) || (grid.loc_to_grid_x(transform.position.x) == 8 && grid.loc_to_grid_z(transform.position.z) == 7)))
            checkS = true;
        else if (dir == "west" && ((grid.loc_to_grid_x(transform.position.x) == 25 && grid.loc_to_grid_z(transform.position.z) == 28) || (grid.loc_to_grid_x(transform.position.x) == 5 && grid.loc_to_grid_z(transform.position.z) == 23) || (grid.loc_to_grid_x(transform.position.x) == 17 && grid.loc_to_grid_z(transform.position.z) == 25) || (grid.loc_to_grid_x(transform.position.x) == 25 && grid.loc_to_grid_z(transform.position.z) == 22) || (grid.loc_to_grid_x(transform.position.x) == 17 && grid.loc_to_grid_z(transform.position.z) == 7) || (grid.loc_to_grid_x(transform.position.x) == 25 && grid.loc_to_grid_z(transform.position.z) == 7)))
            checkS = true;



        else if (dir == "north" && ((grid.loc_to_grid_x(transform.position.x) == 5 && grid.loc_to_grid_z(transform.position.z) == 0) || (grid.loc_to_grid_x(transform.position.x) == 20 && grid.loc_to_grid_z(transform.position.z) == 0) || (grid.loc_to_grid_x(transform.position.x) == 8 && grid.loc_to_grid_z(transform.position.z) == 4) || (grid.loc_to_grid_x(transform.position.x) == 17 && grid.loc_to_grid_z(transform.position.z) == 4) || (grid.loc_to_grid_x(transform.position.x) == 8 && grid.loc_to_grid_z(transform.position.z) == 22) || (grid.loc_to_grid_x(transform.position.x) == 17 && grid.loc_to_grid_z(transform.position.z) == 22)))
        {
            checkE = true;
            checkW = true;
        }
        else if (dir == "south" && ((grid.loc_to_grid_x(transform.position.x) == 11 && grid.loc_to_grid_z(transform.position.z) == 28) || (grid.loc_to_grid_x(transform.position.x) == 14 && grid.loc_to_grid_z(transform.position.z) == 28) || (grid.loc_to_grid_x(transform.position.x) == 2 && grid.loc_to_grid_z(transform.position.z) == 25) || (grid.loc_to_grid_x(transform.position.x) == 23 && grid.loc_to_grid_z(transform.position.z) == 25) || (grid.loc_to_grid_x(transform.position.x) == 11 && grid.loc_to_grid_z(transform.position.z) == 22) || (grid.loc_to_grid_x(transform.position.x) == 14 && grid.loc_to_grid_z(transform.position.z) == 22) || (grid.loc_to_grid_x(transform.position.x) == 8 && grid.loc_to_grid_z(transform.position.z) == 19) || (grid.loc_to_grid_x(transform.position.x) == 17 && grid.loc_to_grid_z(transform.position.z) == 19) || (grid.loc_to_grid_x(transform.position.x) == 11 && grid.loc_to_grid_z(transform.position.z) == 10) || (grid.loc_to_grid_x(transform.position.x) == 14 && grid.loc_to_grid_z(transform.position.z) == 10) || (grid.loc_to_grid_x(transform.position.x) == 11 && grid.loc_to_grid_z(transform.position.z) == 4) || (grid.loc_to_grid_x(transform.position.x) == 14 && grid.loc_to_grid_z(transform.position.z) == 4)))
        {
            checkE = true;
            checkW = true;
        }
        else if (dir == "east" && ((grid.loc_to_grid_x(transform.position.x) == 25 && grid.loc_to_grid_z(transform.position.z) == 4) || (grid.loc_to_grid_x(transform.position.x) == 5 && grid.loc_to_grid_z(transform.position.z) == 7) || (grid.loc_to_grid_x(transform.position.x) == 8 && grid.loc_to_grid_z(transform.position.z) == 13) || (grid.loc_to_grid_x(transform.position.x) == 17 && grid.loc_to_grid_z(transform.position.z) == 16) || (grid.loc_to_grid_x(transform.position.x) == 20 && grid.loc_to_grid_z(transform.position.z) == 22)))
        {
            checkN = true;
            checkS = true;
        }
        else if (dir == "west" && ((grid.loc_to_grid_x(transform.position.x) == 0 && grid.loc_to_grid_z(transform.position.z) == 4) || (grid.loc_to_grid_x(transform.position.x) == 20 && grid.loc_to_grid_z(transform.position.z) == 7) || (grid.loc_to_grid_x(transform.position.x) == 17 && grid.loc_to_grid_z(transform.position.z) == 13) || (grid.loc_to_grid_x(transform.position.x) == 8 && grid.loc_to_grid_z(transform.position.z) == 16) || (grid.loc_to_grid_x(transform.position.x) == 5 && grid.loc_to_grid_z(transform.position.z) == 22)))
        {
            checkN = true;
            checkS = true;
        }


        else if (dir == "north" && ((grid.loc_to_grid_x(transform.position.x) == 5 && grid.loc_to_grid_z(transform.position.z) == 19) || (grid.loc_to_grid_x(transform.position.x) == 20 && grid.loc_to_grid_z(transform.position.z) == 19) || (grid.loc_to_grid_x(transform.position.x) == 5 && grid.loc_to_grid_z(transform.position.z) == 13) || (grid.loc_to_grid_x(transform.position.x) == 20 && grid.loc_to_grid_z(transform.position.z) == 13) || (grid.loc_to_grid_x(transform.position.x) == 5 && grid.loc_to_grid_z(transform.position.z) == 4) || (grid.loc_to_grid_x(transform.position.x) == 20 && grid.loc_to_grid_z(transform.position.z) == 4)))
        {
            checkE = true;
            checkW = true;
            checkS = true;
        }
        else if (dir == "south" && ((grid.loc_to_grid_x(transform.position.x) == 5 && grid.loc_to_grid_z(transform.position.z) == 19) || (grid.loc_to_grid_x(transform.position.x) == 20 && grid.loc_to_grid_z(transform.position.z) == 19) || (grid.loc_to_grid_x(transform.position.x) == 5 && grid.loc_to_grid_z(transform.position.z) == 13) || (grid.loc_to_grid_x(transform.position.x) == 20 && grid.loc_to_grid_z(transform.position.z) == 13) || (grid.loc_to_grid_x(transform.position.x) == 5 && grid.loc_to_grid_z(transform.position.z) == 4) || (grid.loc_to_grid_x(transform.position.x) == 20 && grid.loc_to_grid_z(transform.position.z) == 4)))
        {
            checkN = true;
            checkE = true;
            checkW = true;
        }
        else if (dir == "east" && ((grid.loc_to_grid_x(transform.position.x) == 5 && grid.loc_to_grid_z(transform.position.z) == 19) || (grid.loc_to_grid_x(transform.position.x) == 20 && grid.loc_to_grid_z(transform.position.z) == 19) || (grid.loc_to_grid_x(transform.position.x) == 5 && grid.loc_to_grid_z(transform.position.z) == 13) || (grid.loc_to_grid_x(transform.position.x) == 20 && grid.loc_to_grid_z(transform.position.z) == 13) || (grid.loc_to_grid_x(transform.position.x) == 5 && grid.loc_to_grid_z(transform.position.z) == 4) || (grid.loc_to_grid_x(transform.position.x) == 20 && grid.loc_to_grid_z(transform.position.z) == 4)))
        {
            checkN = true;
            checkW = true;
            checkS = true;
        }
        else if (dir == "west" && ((grid.loc_to_grid_x(transform.position.x) == 5 && grid.loc_to_grid_z(transform.position.z) == 19) || (grid.loc_to_grid_x(transform.position.x) == 20 && grid.loc_to_grid_z(transform.position.z) == 19) || (grid.loc_to_grid_x(transform.position.x) == 5 && grid.loc_to_grid_z(transform.position.z) == 13) || (grid.loc_to_grid_x(transform.position.x) == 20 && grid.loc_to_grid_z(transform.position.z) == 13) || (grid.loc_to_grid_x(transform.position.x) == 5 && grid.loc_to_grid_z(transform.position.z) == 4) || (grid.loc_to_grid_x(transform.position.x) == 20 && grid.loc_to_grid_z(transform.position.z) == 4)))
        {
            checkN = true;
            checkS = true;
            checkE = true;
        }



        double dist = Mathf.Infinity;

        if (checkN == true)
        {
            double f = grid.GetDistance(grid.getPacX(), grid.loc_to_grid_x(transform.position.x), grid.getPacZ(), grid.loc_to_grid_z(transform.position.z) + 1);
            if (f < dist)
                dist = f;
        }
        if (checkS == true)
        {
            double f = grid.GetDistance(grid.getPacX(), grid.loc_to_grid_x(transform.position.x), grid.getPacZ(), grid.loc_to_grid_z(transform.position.z) - 1);
            if (f < dist)
                dist = f;
            else
                checkS = false;
        }
        if (checkE == true)
        {
            double f = grid.GetDistance(grid.getPacX(), grid.loc_to_grid_x(transform.position.x) + 1, grid.getPacZ(), grid.loc_to_grid_z(transform.position.z));
            if (f < dist)
                dist = f;
            else
                checkE = false;
        }
        if (checkW == true)
        {
            double f = grid.GetDistance(grid.getPacX(), grid.loc_to_grid_x(transform.position.x) - 1, grid.getPacZ(), grid.loc_to_grid_z(transform.position.z));
            if (f < dist)
                dist = f;
            else
                checkW = false;
        }


        if (checkW == true)
        {
            transform.eulerAngles = new Vector3(0, 270, 0);
            speed = new Vector3(-1, 0, 0);
            dir = "west";
        }
        else if (checkE == true)
        {
            transform.eulerAngles = new Vector3(0, 90, 0);
            speed = new Vector3(1, 0, 0);
            dir = "east";
        }
        else if (checkS == true)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
            speed = new Vector3(0, 0, -1);
            dir = "south";
        }
        else
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            speed = new Vector3(0, 0, 1);
            dir = "north";
        }

        checkN = false;
        checkS = false;
        checkE = false;
        checkW = false;
    }
}
