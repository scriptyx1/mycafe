using Dapper;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace mycafe.DataBaseData
{
    public class DataAccess : IDataMethods
    {
        // devi mettere tutti i metodi che necessitano di collegarsi a sql, tipo "get all data"
        public void InsertPerson(Users user)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnector.CnnString("CafeDb")))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Username", user.Username);
                p.Add("@Phone", user.Phone);
                p.Add("@Password", user.Password);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);


                connection.Execute("dbo.Users_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }

        public List<Users> GetAllUsers()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnector.CnnString("CafeDb")))
            {
                var output = connection.Query<Users>("dbo.GetAllUsers").ToList();
                return output;
            }
        }

        public void DeleteFromUsersTable(string username)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnector.CnnString("CafeDb")))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Username", username);
                connection.Execute("dbo.DeleteFromUsersTable", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void EditUsersTable(Users user)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnector.CnnString("CafeDb")))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Id", user.Id);
                p.Add("@Username", user.Username);
                p.Add("@Phone", user.Phone);
                p.Add("@Password", user.Password);
                connection.Execute("dbo.EditUsersTable", p, commandType: CommandType.StoredProcedure);
            }
        }

        public Users GetUserById(int userId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnector.CnnString("CafeDb")))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Id", userId);
                return connection.QueryFirstOrDefault<Users>("dbo.GetUserById", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void InsertItem(Items item)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnector.CnnString("CafeDb")))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Nome", item.Nome);
                p.Add("@Prezzo", item.Prezzo);
                p.Add("@Categoria", item.Categoria);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);


                connection.Execute("dbo.ItemsInsert", p, commandType: CommandType.StoredProcedure);
            }
        }

        public List<Items> GetAllItems()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnector.CnnString("CafeDb")))
            {
                var output = connection.Query<Items>("dbo.GetAllItems").ToList();
                return output;
            }
        }

        public void DeleteFromItemsTable(Items item)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnector.CnnString("CafeDb")))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Id", item.Id);
                connection.Execute("dbo.DeleteFromItemsTable", p, commandType: CommandType.StoredProcedure);
            }
        }

        public Items GetItemFromId(int itemId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnector.CnnString("CafeDb")))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Id", itemId);
                return connection.QueryFirstOrDefault<Items>("dbo.GetItemsFromId", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void EditItemsTable(Items item)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnector.CnnString("CafeDb")))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Id", item.Id);
                p.Add("@Nome", item.Nome);
                p.Add("@Prezzo", item.Prezzo);
                p.Add("@Categoria", item.Categoria);
                connection.Execute("dbo.EditItemsTable", p, commandType: CommandType.StoredProcedure);
            }
        }
        public void CreaOrdine(Order order)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnector.CnnString("CafeDb")))
            {
                SaveOrder(connection, order);
                SaveItemsOrder(connection, order);
            }
        }

        public void SaveItemsOrder(IDbConnection connection, Order order)
        {

            foreach (Items item in order.Articoli)
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@OrdineId", order.Id);
                p.Add("@ArticoloId", item.Id);
                p.Add("@Quantità", item.Quantità);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.OrdineArticoliInsert", p, commandType: CommandType.StoredProcedure);
            }

        }

        public void SaveOrder(IDbConnection connection, Order order)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("@Data", order.DateTime);
            p.Add("@UserId", order.user.Id);
            p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.OrderInsert", p, commandType: CommandType.StoredProcedure);

            order.Id = p.Get<int>("@Id");
        }

        public bool LoginCheck(Users user)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnector.CnnString("CafeDb")))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Username", user.Username);
                p.Add("@Password", user.Password);
                user = connection.QueryFirstOrDefault<Users>("dbo.LoginCheck", p, commandType: CommandType.StoredProcedure);

                if (user != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public List<Order> GetAllOrders()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnector.CnnString("CafeDb")))
            {
                var output = connection.Query<Order>("dbo.GetAllOrders").ToList();

                foreach (Order order in output)
                {
                    order.Articoli = GetAllOrderItems(order);
                }
                return output;
            }
        }

        public List<Items> GetAllOrderItems(Order order)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnector.CnnString("CafeDb")))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@OrderId", order.Id);
                var output = connection.Query<Items>("dbo.GetAllOrderItems", p, commandType: CommandType.StoredProcedure).ToList();
                return output;
            }
        }

        public int GetUserIdFromCredential(Users user)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnector.CnnString("CafeDb")))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Username", user.Username);
                p.Add("@Password", user.Password);
                return connection.QueryFirstOrDefault<int>("dbo.GetUserIdFromCredential", p, commandType: CommandType.StoredProcedure);

            }
        }
    }
}

