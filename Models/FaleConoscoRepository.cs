using System;
using System.Collections.Generic;
using MySqlConnector;

namespace Studioarianearaujo_ATV5.Models
{
    public class FaleConoscoRepository
    {
           private const string DadosConexao = "Database=Studioarianearaujo;Data Source=localhost;User Id=root;";

        public void TestarConexao(){
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            Console.WriteLine("Banco de dados funcionando");
            Conexao.Close();
        }

        public void inserir(FaleConosco novoComentario){            

           MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            String Query = "INSERT INTO FaleConosco(Nome,Elogios,Sugestoes) VALUES (@Nome,@Elogios,@Sugestoes)";

            MySqlCommand Comando = new MySqlCommand(Query,Conexao);

            Comando.Parameters.AddWithValue("@Nome",novoComentario.Nome);
            Comando.Parameters.AddWithValue("@Elogios",novoComentario.Elogios);
            Comando.Parameters.AddWithValue("@Sugestoes",novoComentario.Sugestoes);
            Comando.ExecuteNonQuery();

           Conexao.Close();   

        }

        public void atualizar(FaleConosco comentario){
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

          String Query = "UPDATE FaleConosco Set Nome=@Nome,Elogios=@Elogios, Sugestoes=@Sugestoes WHERE Id=@Id";

           MySqlCommand Comando = new MySqlCommand(Query,Conexao);

            Comando.Parameters.AddWithValue("@Nome",comentario.Nome);
            Comando.Parameters.AddWithValue("@Elogios",comentario.Elogios);
            Comando.Parameters.AddWithValue("@Sugestoes",comentario.Sugestoes);            
            Comando.Parameters.AddWithValue("@Id",comentario.Id);

           Comando.ExecuteNonQuery();

            Conexao.Close();

        }

        public void remover(FaleConosco comentario){

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            String Query = "DELETE FROM FaleConosco WHERE Id=@Id";
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);

           Comando.Parameters.AddWithValue("@Id",comentario.Id);
            Comando.ExecuteNonQuery();

            Conexao.Close();

        }

        public FaleConosco BuscarPorID( int Id){
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            FaleConosco comentarioEncontrado = new FaleConosco();

            String Query = "SELECT * FROM FaleConosco WHERE Id=@Id";

            MySqlCommand Comando = new MySqlCommand(Query,Conexao);

            Comando.Parameters.AddWithValue("@Id",Id);

            MySqlDataReader Reader = Comando.ExecuteReader();
            
            if(Reader.Read()){

              comentarioEncontrado.Id = Reader.GetInt32("Id");

              if (!Reader.IsDBNull(Reader.GetOrdinal("Nome"))){  
                  comentarioEncontrado.Nome = Reader.GetString("Nome");                  
                }

              if (!Reader.IsDBNull(Reader.GetOrdinal("Elogios"))){   
                  comentarioEncontrado.Elogios = Reader.GetString("Elogios");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Sugestoes"))){
                  comentarioEncontrado.Sugestoes = Reader.GetString("Sugestoes");
                }
            }

           Conexao.Close();

           return comentarioEncontrado;


        } 

        public List<FaleConosco> Listar(){
        
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            List<FaleConosco> ListaDeComentarios = new List<FaleConosco>();

            String Query = "SELECT * FROM FaleConosco";
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);

           MySqlDataReader Reader = Comando.ExecuteReader();


           while (Reader.Read()){
           
                 FaleConosco ComentarioEncontrado = new FaleConosco();

                 ComentarioEncontrado.Id = Reader.GetInt32("Id");
                           
                  
                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome"))){
                    ComentarioEncontrado.Nome = Reader.GetString("Nome");
               }
                 
               if (!Reader.IsDBNull(Reader.GetOrdinal("Elogios"))){
                   ComentarioEncontrado.Elogios = Reader.GetString("Elogios");
               }
                  
               if (!Reader.IsDBNull(Reader.GetOrdinal("Sugestoes"))){
                    ComentarioEncontrado.Sugestoes = Reader.GetString("Sugestoes");
               }

               ListaDeComentarios.Add(ComentarioEncontrado);            
           }
               
            Conexao.Close();

            return ListaDeComentarios;



        }
    }
}