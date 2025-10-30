using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using AppControleRestaurante;

public class RecadoDAO
{
    // AJUSTE AQUI com sua connection string
    private string connectionString;

    public RecadoDAO(string connString)
    {
        this.connectionString = connString;
    }

    // Inserir novo recado
    public bool InserirRecado(Recado recado)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Recados 
                                (FuncionarioId, FuncionarioNome, EmpresaId, Assunto, Mensagem, DataEnvio, Status) 
                                VALUES 
                                (@FuncionarioId, @FuncionarioNome, @EmpresaId, @Assunto, @Mensagem, @DataEnvio, @Status)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FuncionarioId", recado.FuncionarioId);
                cmd.Parameters.AddWithValue("@FuncionarioNome", recado.FuncionarioNome);
                cmd.Parameters.AddWithValue("@EmpresaId", recado.EmpresaId);
                cmd.Parameters.AddWithValue("@Assunto", recado.Assunto);
                cmd.Parameters.AddWithValue("@Mensagem", recado.Mensagem);
                cmd.Parameters.AddWithValue("@DataEnvio", recado.DataEnvio);
                cmd.Parameters.AddWithValue("@Status", recado.Status);

                conn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao inserir recado: " + ex.Message);
        }
    }

    // Buscar recados de um funcionário
    public List<Recado> BuscarRecadosPorFuncionario(int funcionarioId)
    {
        List<Recado> recados = new List<Recado>();

        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT * FROM Recados 
                                WHERE FuncionarioId = @FuncionarioId 
                                ORDER BY DataEnvio DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FuncionarioId", funcionarioId);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    recados.Add(MapearRecado(reader));
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao buscar recados: " + ex.Message);
        }

        return recados;
    }

    // Buscar todos os recados de uma empresa
    public List<Recado> BuscarRecadosPorEmpresa(int empresaId)
    {
        List<Recado> recados = new List<Recado>();

        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT * FROM Recados 
                                WHERE EmpresaId = @EmpresaId 
                                ORDER BY DataEnvio DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EmpresaId", empresaId);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    recados.Add(MapearRecado(reader));
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao buscar recados: " + ex.Message);
        }

        return recados;
    }

    // Atualizar status
    public bool AtualizarStatus(int recadoId, string novoStatus)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Recados SET Status = @Status WHERE Id = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Status", novoStatus);
                cmd.Parameters.AddWithValue("@Id", recadoId);

                conn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao atualizar status: " + ex.Message);
        }
    }

    // Adicionar resposta
    public bool AdicionarResposta(int recadoId, string resposta)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Recados 
                                SET Resposta = @Resposta, 
                                    DataResposta = @DataResposta,
                                    Status = 'Respondido'
                                WHERE Id = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Resposta", resposta);
                cmd.Parameters.AddWithValue("@DataResposta", DateTime.Now);
                cmd.Parameters.AddWithValue("@Id", recadoId);

                conn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao adicionar resposta: " + ex.Message);
        }
    }

    // Contar pendentes
    public int ContarRecadosPendentes(int empresaId)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT COUNT(*) FROM Recados 
                                WHERE EmpresaId = @EmpresaId 
                                AND Status = 'Pendente'";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EmpresaId", empresaId);

                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao contar recados: " + ex.Message);
        }
    }

    // Mapear dados do banco para objeto
    private Recado MapearRecado(SqlDataReader reader)
    {
        return new Recado
        {
            Id = Convert.ToInt32(reader["Id"]),
            FuncionarioId = Convert.ToInt32(reader["FuncionarioId"]),
            FuncionarioNome = reader["FuncionarioNome"].ToString(),
            EmpresaId = Convert.ToInt32(reader["EmpresaId"]),
            Assunto = reader["Assunto"].ToString(),
            Mensagem = reader["Mensagem"].ToString(),
            DataEnvio = Convert.ToDateTime(reader["DataEnvio"]),
            Status = reader["Status"].ToString(),
            Resposta = reader["Resposta"] != DBNull.Value ? reader["Resposta"].ToString() : null,
            DataResposta = reader["DataResposta"] != DBNull.Value ? Convert.ToDateTime(reader["DataResposta"]) : (DateTime?)null
        };
    }
}
