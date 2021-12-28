using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace ZakazBar
{
    public static class DataAccess
    {
        public static List<ALKO> GetALKO()
        {
            List<ALKO> alk = new List<ALKO>(DBconnection.connection.ALKO);
            List<ALKO> ALKO = new List<ALKO>();
            foreach (var t in alk)
            {
                ALKO.Add(
                new ALKO
                {
                    Id_alko = t.Id_alko,
                    Name = t.Name,
                    Price = t.Price,
                });
            }
            return ALKO;
        }

        public static ALKO GetALKO(int Id_alko)
        {
            List<ALKO> users = GetALKO();
            return users.Where(a => a.Id_alko == Id_alko).FirstOrDefault();
        }

        public static ALKO GetALKO(string Name)
        {
            List<ALKO> userss = GetALKO();
            return userss.Where(t => t.Name == Name).FirstOrDefault();
        }
        public static bool AddNewALKO(ALKO users)
        {
            try
            {
                DBconnection.connection.ALKO.Add(users);
                DBconnection.connection.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void DeleteALKO(int Id_alko)
        {
            List<ALKO> users = GetALKO();
            var user = users.Where(t => t.Id_alko == Id_alko).FirstOrDefault();

            DBconnection.connection.ALKO.Remove(user);
            DBconnection.connection.SaveChanges();
        }

        public static void UpdateALKO(int Id_alko, ALKO users)
        {

            DBconnection.connection.ALKO.SingleOrDefault(t => t.Id_alko == Id_alko);
            DBconnection.connection.SaveChanges();

        }

        public static void DeleteALKO(ALKO users)
        {
            DBconnection.connection.ALKO.Remove(users);
            DBconnection.connection.SaveChanges();
        }
       
        /*----------------------------------------------------------------------------------------------------*/
        public static List<zakaz> Getzakaz()
        {
            List<zakaz> users = new List<zakaz>(DBconnection.connection.zakaz);
            List<zakaz> userss = new List<zakaz>();
            foreach (var t in users)
            {
                userss.Add(
                new zakaz
                {
                    ID = t.ID,
                    item = t.item,
                    Price = t.Price,
                });
            }
            return userss;
        }

        public static List<zakaz> Getzakaz(int ID)
        {
            List<zakaz> users = Getzakaz();
            return users.Where(a => a.ID == ID).ToList();
        }

        public static zakaz Getzakaz(string item)
        {
            List<zakaz> userss = Getzakaz();
            return userss.Where(t => t.item == item).FirstOrDefault();
        }

        public static bool AddNewzakaz(zakaz users)
        {
            try
            {
                DBconnection.connection.zakaz.Add(users);
                DBconnection.connection.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void Deletezakaz(int ID)
        {
            List<zakaz> users = Getzakaz();
            var user = users.Where(t => t.ID == ID).FirstOrDefault();

            DBconnection.connection.zakaz.Remove(user);
            DBconnection.connection.SaveChanges();
        }

        public static void Updatezakaz(int ID, zakaz users)
        {

            DBconnection.connection.zakaz.SingleOrDefault(t => t.ID == ID);
            DBconnection.connection.SaveChanges();

        }

        public static void Deletezakaz(zakaz users)
        {
            DBconnection.connection.zakaz.Remove(users);
            DBconnection.connection.SaveChanges();
        }
        /*----------------------------------------------------------------------------------------------------*/
        public static List<Employee> GetEmployee()
        {
            List<Employee> users = new List<Employee>(DBconnection.connection.Employee);
            List<Employee> userss = new List<Employee>();
            foreach (var t in users)
            {
                userss.Add(
                new Employee
                {
                    ID = t.ID,
                    Name = t.Name,
                    age = t.age,
                    id_position = t.id_position

                });
            }
            return userss;
        }

        public static List<Employee> GetEmployee(int ID)
        {
            List<Employee> users = GetEmployee();
            return users.Where(a => a.ID == ID).ToList();
        }
        public static Employee GetEmployee(string Name)
        {
            List<Employee> userss = GetEmployee();
            return userss.Where(t => t.Name == Name).FirstOrDefault();
        }
        
        public static bool AddNewEmployee(Employee users)
        {
            try
            {
                DBconnection.connection.Employee.Add(users);
                DBconnection.connection.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void DeleteEmployee(int ID)
        {
            List<Employee> users = GetEmployee();
            var user = users.Where(t => t.ID == ID).FirstOrDefault();

            DBconnection.connection.Employee.Remove(user);
            DBconnection.connection.SaveChanges();
        }

        public static void UpdateEmployee(int ID, Employee users)
        {

            DBconnection.connection.Employee.SingleOrDefault(t => t.ID == ID);
            DBconnection.connection.SaveChanges();

        }

        public static void DeleteEmployee(Employee users)
        {
            DBconnection.connection.Employee.Remove(users);
            DBconnection.connection.SaveChanges();
        }
        /*----------------------------------------------------------------------------------------------------*/
        public static List<Position> GetPosition()
        {
            List<Position> users = new List<Position>(DBconnection.connection.Position);
            List<Position> userss = new List<Position>();
            foreach (var t in users)
            {
                userss.Add(
                new Position
                {
                    id_position = t.id_position,
                    title = t.title

                });
            }
            return userss;
        }

        public static List<Position> GetPosition(int id_position)
        {
            List<Position> users = GetPosition();
            return users.Where(a => a.id_position == id_position).ToList();
        }
        public static Position GetPosition(string title)
        {
            List<Position> userss = GetPosition();
            return userss.Where(t => t.title == title).FirstOrDefault();
        }

        public static bool AddNewPosition(Position users)
        {
            try
            {
                DBconnection.connection.Position.Add(users);
                DBconnection.connection.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void DeletePosition(int id_position)
        {
            List<Position> users = GetPosition();
            var user = users.Where(t => t.id_position == id_position).FirstOrDefault();

            DBconnection.connection.Position.Remove(user);
            DBconnection.connection.SaveChanges();
        }

        public static void UpdatePosition(int id_position, Employee users)
        {

            DBconnection.connection.Position.SingleOrDefault(t => t.id_position == id_position);
            DBconnection.connection.SaveChanges();

        }

        public static void DeletePosition(Position users)
        {
            DBconnection.connection.Position.Remove(users);
            DBconnection.connection.SaveChanges();
        }

    }
}
