using System;
using System.Collections.Generic;
using ProjectInter.Models;
using ProjectInter.Data.Interfaces;
using System.Data.SqlClient;
using System.Data;

namespace ProjectInter.Data.Repositories
{
    public class CustomersRepository : BDContext, ICustomersRepository
    {
        public void Create(Customers customers, Address address)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                cmd.CommandText = "cadCliente";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nome", customers.Name);
                cmd.Parameters.AddWithValue("@celular", customers.Cellphone);
                cmd.Parameters.AddWithValue("@email", customers.Email);
                cmd.Parameters.AddWithValue("@senha", customers.Password);
                cmd.Parameters.AddWithValue("@cpf", customers.Cpf);
                cmd.Parameters.AddWithValue("@endereco", address.NameAddress);
                cmd.Parameters.AddWithValue("@complemento", address.ComplementAddress);
                cmd.Parameters.AddWithValue("@numero_endereco", address.NumberAddress);
                cmd.Parameters.AddWithValue("@bairro", address.District);
                cmd.Parameters.AddWithValue("@cep", address.ZipCodeAddress);
                cmd.ExecuteNonQuery();


            } catch(Exception ex){
                Console.WriteLine("Erro: " + ex.Message);
            } finally{
                Dispose();
            }
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Customers GetCustomer(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Customers> GetAllCustomers()
        {
            throw new System.NotImplementedException();
        }

        public void Update(int id, Customers customers)
        {
            throw new System.NotImplementedException();
        }
    }
}
