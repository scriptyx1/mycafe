using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mycafe.DataBaseData
{
    public interface IDataMethods
    {
         void InsertPerson(Users user);
         List<Users> GetAllUsers();
         void DeleteFromUsersTable(string username);
        void EditUsersTable(Users user);
        Users GetUserById(int userId);
        void InsertItem(Items item);
        List<Items> GetAllItems();
        void DeleteFromItemsTable(Items item);
        Items GetItemFromId(int itemId);
        void EditItemsTable(Items item);
        void SaveItemsOrder(IDbConnection connection, Order order);
        void SaveOrder(IDbConnection connection, Order order);
        void CreaOrdine(Order order);
        bool LoginCheck(Users user);
        List<Order> GetAllOrders();
        List<Items> GetAllOrderItems(Order order);
        int GetUserIdFromCredential(Users user);



    }
}
