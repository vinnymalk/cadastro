using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CadastroProj
{
    internal static class UtilBd
    {
        private static MySqlConnection Conn = new MySqlConnection("Server=127.0.0.1;Database=cadastrousuario;Uid=root;Pwd=123456;"); // conexão com BD

        public static void ExecutarInserirAtualizarExcluir(string query, MySqlParameter[] parametro = null) // recebe consulta SQL (query), E parâmetros da consulta
        {
            try
            {
                Conn.Open();// abrir conexão com o BD

                MySqlCommand cmd = new MySqlCommand(query, Conn); // recebe a query da consulta

                if (parametro != null) // verifica se o parâmetro está como NUlo
                {
                    cmd.Parameters.AddRange(parametro); // passando os paramtros para o cmd ; adicionar o paramentro
                }

                cmd.ExecuteNonQuery(); // excutar a query que cmd recebe
                Conn.Close(); // fecha conexão 
            }
            catch // verifica se teve exceção 
            {
                Conn.Close(); // fechar a conexão
                throw;
            }
        }

        public static List<T> Selecionar<T>(string query, MySqlParameter[] parametroSe = null) // retorno de informação executada . recebe uma consulta SQL recebendo os parametros
        {

            try // tratador de exceções (tentador) 
            {
                Conn.Open(); // abrir conexão

                MySqlCommand cmd = new MySqlCommand(query, Conn); // recebe uma query na variável cmd

                if (parametroSe != null) // verifica se parametro é nulo
                {
                    cmd.Parameters.AddRange(parametroSe); // cmd está recebendo os parametros . adicionar parametros
                }

                MySqlDataReader selecao = cmd.ExecuteReader(); // lendo os parametros em cmd e "rodando" os valores

                List<T> list = DataReaderMapToList<T>(selecao); //  
                Conn.Close();

                return list;
            }
            catch
            {
                Conn.Close();


                throw;
            }

        }


        public static List<T> DataReaderMapToList<T>(IDataReader dr) // lista mórfica para receber valor em dr
        {
            List<T> list = new List<T>(); // instanciar uma nova lista
            T? pessoa; // fala que pessoa é nulável
            while (dr.Read()) // vai rodar enquanto tiver linhas para ler
            {
                pessoa = Activator.CreateInstance<T>(); // instanciar pessoa

                var propriedadesDaPessoa = pessoa!.GetType().GetProperties(); // mostra as propriedades da pessoa 

                foreach (PropertyInfo propriedade in propriedadesDaPessoa) // rodar pegando as informação de propriedades e valor de cada uma das propriedades no BD
                {
                    var valorDaColuna = dr[propriedade.Name]; // recebendo o valor da coluna que está sendo tratado

                    if (!valorDaColuna.Equals(DBNull.Value)) // ve se a coluna está vazia como Null
                    {                        
                        propriedade.SetValue(pessoa, valorDaColuna, null); // vai colocar o valor da coluna na pessoa
                    }
                }

                list.Add(pessoa); // armazenar a pessoa (completa) à lista.
            }
            return list; // retorna lista
        }

    }
}
