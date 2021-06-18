using System;
using System.Windows.Forms;

namespace cad_voo
{
    public partial class Ecma : Form
    {
        #region Page Load

        // Variável string de conexão
        private string strConexao = "Data Source = CENTER; Initial Catalog = projet; Integrated Security = True";
        public int? codigo = null;
        private char tipo;
        public DateTime data;
        public decimal custo = 0;
        public int distancia = 0;
        public char indicador;
        public int nivel = 0;

        private int? _Hidden = null;

        public Ecma()
        {
            InitializeComponent();
        }

        private void Ecma_Load(object sender, EventArgs e)
        {

            habilitaCampos(false);

            CarregaDados();
            btnExcluir.Enabled = false;

        }

        #endregion

        #region Botões

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            tipo = 'I';
            Limpar();
            btnExcluir.Enabled = false;
            habilitaCampos(true);

            dtVoo.Focus();


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Conexao c = new Conexao(strConexao);
            DALConnect d = new DALConnect(c);

            var resposta = MessageBox.Show("Confirmar exclusão do contato", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resposta.ToString() == "Yes")
            {
                d.Excluir(_Hidden);
                MessageBox.Show("Registro excluido!");
                Limpar();
                CarregaDados();

                habilitaCampos(false);
                btnExcluir.Enabled = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!Valida()) return;

            try
            {
                Gravar();
                Limpar();
                CarregaDados();
                habilitaCampos(false);

            }
            catch
            {

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();

            habilitaCampos(false);
            btnExcluir.Enabled = false;
            
        }

        #endregion

        #region Métodos

        protected void Gravar()
        {
            Cadastro cad = new Cadastro();
            Conexao con = new Conexao(strConexao);
            DALConnect d = new DALConnect(con);

            cad.data_voo = Convert.ToDateTime(dtVoo.Text);
            cad.custo = Convert.ToDecimal(txtCusto.Text);
            cad.distancia = Convert.ToInt32(txtDistancia.Text);
            cad.captura = (rbSim.Checked == true) ? 'S' : 'N';
            cad.nivel = Convert.ToInt32(txtNivel.Text);

            try
            {
                switch (tipo)
                {
                    case 'I':
                        d.Incluir(cad);
                        MessageBox.Show("Cadastrado com sucesso! Número do registro: " + cad.codigo.ToString());
                        break;
                    case 'U':
                        cad.codigo = Convert.ToInt32(txtCodigo.Text);
                        d.Alterar(cad);
                        MessageBox.Show("Alterado com sucesso!");
                        break;
                }

            }
            catch
            {

            }
            finally
            {
                cad = null;
                con = null;
                d = null;
            }

        }

        private void Limpar()
        {
            dtVoo.Text = "";
            txtCusto.Text = "";
            txtDistancia.Text = "";
            txtNivel.Text = "";

        }

        protected bool Valida()
        {
            if (string.IsNullOrWhiteSpace(dtVoo.Text))
            {
                MessageBox.Show("Informe a data do voo");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtCusto.Text))
            {
                MessageBox.Show("Informe o custo do foguete");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtDistancia.Text))
            {
                MessageBox.Show("Informe a distancia alcançada");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtNivel.Text))
            {
                MessageBox.Show("Informe o nível de dor ao final do teste");
                return false;
            }
            else if (Convert.ToInt32(txtNivel.Text) < 0 || Convert.ToInt32(txtNivel.Text) > 10)
            {
                MessageBox.Show("Informe o nível dor entre 0 e 10");
                return false;
            }
            else return true;

        }

        protected void habilitaCampos(bool formulario)
        {
            groupBox2.Enabled = formulario;
        }

        #endregion

        #region Pesquisar

        private void CarregaDados()
        {
            Conexao oConnect = new Conexao(strConexao);
            DALConnect oConsulta = new DALConnect(oConnect);

            gvConsulta.DataSource = oConsulta.Pesquisar();

            gvConsulta.Columns[0].HeaderText = "Id Voo";
            gvConsulta.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            gvConsulta.Columns[0].Width = 0;
            gvConsulta.Columns[0].Visible = false;

        }

        #endregion

        #region Grid

        private void gvConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this._Hidden = Convert.ToInt32(gvConsulta.Rows[e.RowIndex].Cells[0].Value);

            Consultar(_Hidden);

            btnExcluir.Enabled = true;

        }

        private void Consultar(int? codigo)
        {
            if (codigo != 0)
            {
                Conexao c = new Conexao(strConexao);
                DALConnect d = new DALConnect(c);
                Cadastro cad = d.SelCadastro(codigo);

                txtCodigo.Text = cad.codigo.ToString();
                dtVoo.Text = Convert.ToString(cad.data_voo);
                txtCusto.Text = Convert.ToString(cad.custo);
                txtDistancia.Text = Convert.ToString(cad.distancia);
                txtNivel.Text = Convert.ToString(cad.nivel);


                if (Convert.ToChar(cad.captura) == 'S')
                    rbSim.Select();
                else
                    rbNao.Select();

                tipo = 'U';
                habilitaCampos(true);
            }


        }

        #endregion
    }


}
