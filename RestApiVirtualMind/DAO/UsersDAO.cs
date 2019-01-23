using RestApiUsers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestApiUsers.DTO;
using System.Data.SqlClient;
using System.Data;
using RestApiUsers.Constants;

namespace RestApiCotizacion.DAO
{
    public class UsersDAO :  IUsersDAO
    {
        private string conn;

        public UsersDAO()
        {
            conn = System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
        }

        public int Create(UserDTO user)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                using (SqlCommand cmd = new SqlCommand(UserConstants.SP_CREATE_USER, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = user.nombre;
                    cmd.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = user.apellido;
                    cmd.Parameters.Add("@UserId", SqlDbType.Int).Value = user.userId;
                    cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = user.email;
                    cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = user.password;

                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int userId)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                using (SqlCommand cmd = new SqlCommand(UserConstants.SP_DELETE_USER, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@UserId", SqlDbType.Int).Value = userId;
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private UserDTO GetUserDTOFromDataRow(DataRow row)
        {
            return new UserDTO()
            {
                apellido = row.Field<string>("Apellido"),
                nombre = row.Field<string>("Nombre"),
                email = row.Field<string>("Email"),
                password = row.Field<string>("Password"),
                userId = row.Field<int>("UserId")
            };
        }
        public List<UserDTO> GetAll()
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                using (SqlCommand cmd = new SqlCommand(UserConstants.SP_GET_USERS, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();

                    using (var da = new SqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        da.Fill(table);

                        var users = from row in table.AsEnumerable()
                                    select GetUserDTOFromDataRow(row);
                        return users.ToList();
                    }

                }
            }
        }

        public UserDTO GetById(int userId)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                using (SqlCommand cmd = new SqlCommand(UserConstants.SP_GET_USER_BY_ID, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@UserId", SqlDbType.Int).Value = userId;
                    con.Open();

                    using (var da = new SqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        da.Fill(table);

                        var user = from row in table.AsEnumerable()
                                    select GetUserDTOFromDataRow(row);
                        return user.SingleOrDefault();
                    }
                }
            }
        }
    }
}