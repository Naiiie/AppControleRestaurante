using System;
using System.Drawing;
using System.Windows.Forms;
using AppControleRestaurante;

public partial class RecadosFuncionarioControl : UserControl
{
    private int funcionarioId;
    private string funcionarioNome;
    private int empresaId;
    private RecadoDAO recadoDAO;

    private ComboBox cmbAssunto;
    private TextBox txtMensagem;
    private Button btnEnviar;
    private DataGridView dgvMeusRecados;
    private Button btnAtualizar;
    private Label lblTitulo;
    private GroupBox grpNovoRecado;
    private GroupBox grpHistorico;

    public RecadosFuncionarioControl()
    {
        InicializarComponentesManualmente();
    }

    public void ConfigurarFuncionario(int funcId, string funcNome, int empId, string connectionString)
    {
        this.funcionarioId = funcId;
        this.funcionarioNome = funcNome;
        this.empresaId = empId;
        this.recadoDAO = new RecadoDAO(connectionString);
        CarregarRecados();
    }

    private void InicializarComponentesManualmente()
    {
        this.Size = new Size(800, 600);
        this.BackColor = Color.White;

        lblTitulo = new Label
        {
            Text = "Enviar Recado para Administração",
            Font = new Font("Segoe UI", 14, FontStyle.Bold),
            Location = new Point(20, 20),
            Size = new Size(400, 30)
        };

        grpNovoRecado = new GroupBox
        {
            Text = "Novo Recado",
            Location = new Point(20, 60),
            Size = new Size(760, 200),
            Font = new Font("Segoe UI", 10)
        };

        Label lblAssunto = new Label
        {
            Text = "Assunto:",
            Location = new Point(20, 30),
            Size = new Size(100, 20),
            Parent = grpNovoRecado
        };

        cmbAssunto = new ComboBox
        {
            Location = new Point(120, 28),
            Size = new Size(600, 25),
            DropDownStyle = ComboBoxStyle.DropDownList,
            Parent = grpNovoRecado
        };
        cmbAssunto.Items.AddRange(new string[] {
            "Sugestão",
            "Problema",
            "Dúvida",
            "Solicitação",
            "Reclamação",
            "Elogio",
            "Outro"
        });
        cmbAssunto.SelectedIndex = 0;

        Label lblMensagem = new Label
        {
            Text = "Mensagem:",
            Location = new Point(20, 65),
            Size = new Size(100, 20),
            Parent = grpNovoRecado
        };

        txtMensagem = new TextBox
        {
            Location = new Point(20, 90),
            Size = new Size(700, 60),
            Multiline = true,
            ScrollBars = ScrollBars.Vertical,
            Parent = grpNovoRecado
        };

        btnEnviar = new Button
        {
            Text = "Enviar Recado",
            Location = new Point(620, 160),
            Size = new Size(100, 30),
            BackColor = Color.FromArgb(0, 120, 215),
            ForeColor = Color.White,
            FlatStyle = FlatStyle.Flat,
            Cursor = Cursors.Hand,
            Parent = grpNovoRecado
        };
        btnEnviar.FlatAppearance.BorderSize = 0;
        btnEnviar.Click += BtnEnviar_Click;

        grpHistorico = new GroupBox
        {
            Text = "Meus Recados Enviados",
            Location = new Point(20, 280),
            Size = new Size(760, 300),
            Font = new Font("Segoe UI", 10)
        };

        dgvMeusRecados = new DataGridView
        {
            Location = new Point(20, 30),
            Size = new Size(720, 220),
            ReadOnly = true,
            AllowUserToAddRows = false,
            AllowUserToDeleteRows = false,
            SelectionMode = DataGridViewSelectionMode.FullRowSelect,
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
            BackgroundColor = Color.White,
            BorderStyle = BorderStyle.Fixed3D,
            Parent = grpHistorico
        };

        btnAtualizar = new Button
        {
            Text = "Atualizar Lista",
            Location = new Point(620, 260),
            Size = new Size(100, 30),
            BackColor = Color.FromArgb(0, 120, 215),
            ForeColor = Color.White,
            FlatStyle = FlatStyle.Flat,
            Cursor = Cursors.Hand,
            Parent = grpHistorico
        };
        btnAtualizar.FlatAppearance.BorderSize = 0;
        btnAtualizar.Click += BtnAtualizar_Click;

        this.Controls.Add(lblTitulo);
        this.Controls.Add(grpNovoRecado);
        this.Controls.Add(grpHistorico);
    }

    private void BtnEnviar_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtMensagem.Text))
        {
            MessageBox.Show("Por favor, escreva uma mensagem.", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            Recado novoRecado = new Recado
            {
                FuncionarioId = this.funcionarioId,
                FuncionarioNome = this.funcionarioNome,
                EmpresaId = this.empresaId,
                Assunto = cmbAssunto.SelectedItem.ToString(),
                Mensagem = txtMensagem.Text.Trim(),
                DataEnvio = DateTime.Now,
                Status = "Pendente"
            };

            recadoDAO.InserirRecado(novoRecado);

            MessageBox.Show("Recado enviado com sucesso!", "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtMensagem.Clear();
            cmbAssunto.SelectedIndex = 0;
            CarregarRecados();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao enviar recado: " + ex.Message, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void BtnAtualizar_Click(object sender, EventArgs e)
    {
        CarregarRecados();
    }

    private void CarregarRecados()
    {
        try
        {
            var recados = recadoDAO.BuscarRecadosPorFuncionario(funcionarioId);

            dgvMeusRecados.DataSource = null;
            dgvMeusRecados.DataSource = recados;

            if (dgvMeusRecados.Columns.Count > 0)
            {
                dgvMeusRecados.Columns["Id"].Visible = false;
                dgvMeusRecados.Columns["FuncionarioId"].Visible = false;
                dgvMeusRecados.Columns["FuncionarioNome"].Visible = false;
                dgvMeusRecados.Columns["EmpresaId"].Visible = false;

                dgvMeusRecados.Columns["DataEnvio"].HeaderText = "Data";
                dgvMeusRecados.Columns["DataEnvio"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                dgvMeusRecados.Columns["Assunto"].HeaderText = "Assunto";
                dgvMeusRecados.Columns["Mensagem"].HeaderText = "Mensagem";
                dgvMeusRecados.Columns["Status"].HeaderText = "Status";
                dgvMeusRecados.Columns["Resposta"].HeaderText = "Resposta Admin";
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao carregar recados: " + ex.Message, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}