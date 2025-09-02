using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BackerCommerce.Model
{
    public class Usuário
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        //* Cadastrar
        //* logar
        //* Modificar
        // *Remover
        /* Exemplo de método DQL utilizando SELECT */
        public DataTable Logar()
        {

            string comando = "Select * From usuarios WHERE email = @email AND senha = @senha";
            /*
            Caso vá utilizar o WHERE, empregue o uso de caracteres coringas,
            semelhante ao apresentado no metódo Cadastrar() acima.
            */
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            // Obter o hash da Senha:
            string senhahash = EasyEncryption.SHA.ComputeSHA256Hash(Senha);


            // Substituir os caracteres Coringas (@)
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@Senha", senhahash);
            cmd.Prepare();

            // Declarar tabela que irá receber o resultado:
            DataTable tabela = new DataTable();
            // Preencher a tabela com o resultado da consulta
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }
        public DataTable listar()
        {
            string comando = "Select * From usuarios";
            /*
            Caso vá utilizar o WHERE, empregue o uso de caracteres coringas,
            semelhante ao apresentado no metódo Cadastrar() acima.
            */
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);


            cmd.Prepare();
            // Declarar tabela que irá receber o resultado:
            DataTable tabela = new DataTable();
            // Preencher a tabela com o resultado da consulta
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;



        }

        public bool Cadastrar()
        {
            string comando = "INSERT INTO usuario (nome_Completo,email,senha)"+
                    "@nome_completo,@email,@senha";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nome_completo", NomeCompleto);
            cmd.Parameters.AddWithValue("@email", Email);
            string senhahash = EasyEncryption.SHA.ComputeSHA256Hash(Senha);
            cmd.Parameters.AddWithValue("@senha", senhahash);
            // Obs.: Certifique-se de utilizar alguma método para obter o hash da senha antes de cadastrar!
            cmd.Prepare();
            // O trecho abaixo irá retornar true caso o cadastro dê certo:
            // Em caso de erro, experimente comentar o try/catch e executar novamente o código;
            // Grande parte dos problemas estão associados à um comando SQL incorreto. Verifique a string comando.
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }
        




    }
    

}

