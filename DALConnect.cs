using System;
using System.Data;
using System.Data.SqlClient;

namespace cad_voo
{
    class DALConnect
    {
        private Conexao objConex;

        public DALConnect(Conexao conexao)
        {
            objConex = conexao;
        }

        public void Incluir(Cadastro voo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConex.objConex;
            cmd.CommandText = "insert into tb_voo(data_voo, custo, distancia, captura, nivel_dor) values(@p_Data, @p_Custo, @p_Distancia, @p_Captura, @p_Nivel); select @@Identity;";
            cmd.Parameters.AddWithValue("@p_Data", voo.data_voo);
            cmd.Parameters.AddWithValue("@p_Custo", voo.custo);
            cmd.Parameters.AddWithValue("@p_Distancia", voo.distancia);
            cmd.Parameters.AddWithValue("@p_Captura", voo.captura);
            cmd.Parameters.AddWithValue("@p_Nivel", voo.nivel);
            objConex.Conectar();
            voo.codigo = Convert.ToInt32(cmd.ExecuteScalar());
            objConex.Desconectar();
        }

        public void Alterar(Cadastro voo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConex.objConex;
            cmd.CommandText = "update tb_voo set data_voo = @p_Data, custo = @p_Custo, distancia = @p_Distancia, captura = @p_Captura, nivel_dor = @p_Nivel where id_voo = @p_Id";
            cmd.Parameters.AddWithValue("@p_Id", voo.codigo);
            cmd.Parameters.AddWithValue("@p_Data", voo.data_voo);
            cmd.Parameters.AddWithValue("@p_Custo", voo.custo);
            cmd.Parameters.AddWithValue("@p_Distancia", voo.distancia);
            cmd.Parameters.AddWithValue("@p_Captura", voo.captura);
            cmd.Parameters.AddWithValue("@p_Nivel", voo.nivel);
            objConex.Conectar();
            cmd.ExecuteNonQuery();
            objConex.Desconectar();
        }


        public void Excluir(int? codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConex.objConex;
            cmd.CommandText = "delete from tb_voo where id_voo = @p_Id";
            cmd.Parameters.AddWithValue("@p_Id", codigo);
            objConex.Conectar();
            cmd.ExecuteNonQuery();
            objConex.Desconectar();
        }

        public DataTable Pesquisar()
        {
            DataTable oDt = new DataTable();
            SqlDataAdapter oLista = new SqlDataAdapter("select id_voo, data_voo as Data, captura as Captura, nivel_dor as Nível from tb_voo", objConex.StringConexao);
            oLista.Fill(oDt);
            return oDt;
        }

        public Cadastro SelCadastro(int? codigo)
        {
            Cadastro oCad = new Cadastro();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConex.objConex;
            cmd.CommandText = "select * from tb_voo where id_voo = " + codigo.ToString();
            objConex.Conectar();
            SqlDataReader regSel = cmd.ExecuteReader();

            if (regSel.HasRows)
            {
                regSel.Read();
                oCad.codigo = Convert.ToInt32(regSel["id_voo"]);
                oCad.data_voo = Convert.ToDateTime(regSel["data_voo"]);
                oCad.custo = Convert.ToDecimal(regSel["custo"]);
                oCad.distancia = Convert.ToInt32(regSel["distancia"]);
                oCad.captura = Convert.ToChar(regSel["captura"]);
                oCad.nivel = Convert.ToInt32(regSel["nivel_dor"]);
            }

            return oCad;

        }

    }
}
