using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class Room_Service
    {
        Rooms_DAO room_db = new Rooms_DAO();

        public List<Room> GetRooms()
        {
            try
            {
                List<Room> room = room_db.Db_Get_All_Rooms();
                return room;
            }
            catch (Exception)
            {
                // something went wrong connecting to the database, so we will add a fake room to the list to make sure the rest of the application continues working!
                List<Room> room = new List<Room>();
                Room a = new Room();
                a.Capacity = 1000;

                room.Add(a);
                Room b = new Room();
                b.Capacity = 1000;

                room.Add(b);
                return room;
                //throw new Exception("Someren couldn't connect to the database");
            }

        }
    }
}
