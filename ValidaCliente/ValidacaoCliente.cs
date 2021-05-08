using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ValidaCliente
{
    public partial class frmValidacao : Form
    {
        public static string DiretorioSaida = string.Empty;

        List<Cliente> tempListClientes;
        List<Cliente> ClientesComFaturas;
        List<Cliente> ClientesSemFaturas;
        List<Cliente> ListaPaginas6;
        List<Cliente> ListaPaginas12;
        List<Cliente> ListaPaginasMaiorQue12;
        public frmValidacao()
        {
            InitializeComponent();
        }

        private void btnSelecionaArquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            DialogResult result = openFile.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                txtNomeArquivo.Text = openFile.FileName;
                StreamReader reader = new StreamReader(openFile.FileName);
                string linha = string.Empty;
                string cabecalho = reader.ReadLine();
                tempListClientes = new List<Cliente>();

                while ((linha = reader.ReadLine()) != null)
                {
                    Cliente Cliente = new Cliente();
                    PreencheDadosCliente(linha, Cliente);
                    bool cepValido = ValidaCEP(Cliente.CEP);
                    if (cepValido)
                    {
                        tempListClientes.Add(Cliente);
                    }
                }
            }
        }

        private static void CriacaoArquivo(List<Cliente> ListaPagina, int id)
        {
            string NomeDoArquivo = string.Empty;
            if (id == 1)
                NomeDoArquivo = DiretorioSaida + @"\ListaAte6Paginas.csv";
            if (id == 2)
                NomeDoArquivo = DiretorioSaida + @"\ListaEntre6e12Paginas.csv";
            if (id == 3)
                NomeDoArquivo = DiretorioSaida + @"\ListaMaiorQue12Paginas.csv";

            try
            {
                if (File.Exists(NomeDoArquivo))
                {
                    File.Delete(NomeDoArquivo);
                }

                using (StreamWriter sw = File.CreateText(NomeDoArquivo))
                {
                    bool cabecalho1 = false;
                    bool cabecalho2 = false;
                    foreach (Cliente cliente in ListaPagina)
                    {
                        if (!string.IsNullOrEmpty(cliente.NomeCompleto))
                        {
                            if (cliente.ValorFatura > 0 && cabecalho1 == false)
                            {
                                sw.WriteLine("NomeCliente;CEP;RuaComComplemento;Bairro;Cidade;Estado;ValorFatura;NumeroPaginas;");
                                cabecalho1 = true;
                            }
                            if (cliente.ValorFatura == 0 && cabecalho2 == false)
                            {
                                sw.WriteLine("======================================CLIENTES SEM FATURA======================================================");
                                cabecalho2 = true;
                            }
                            sw.WriteLine(cliente.NomeCompleto + ";" + cliente.CEP + ";" + cliente.RuaComComplemento + ";" + cliente.Bairro + ";" + cliente.Cidade + ";" + cliente.Estado + ";" + cliente.ValorFatura + ";" + cliente.NumeroPaginas);
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

        private static void SeparacaoPorPaginas(List<Cliente> Clientes, List<Cliente> ListaPaginas6, List<Cliente> ListaPagina12, List<Cliente> ListaPaginaMaiorQue12, bool separador)
        {
            foreach (Cliente clienteComFatura in Clientes)
            {
                if (clienteComFatura.NumeroPaginas <= 6)
                {
                    if (!(clienteComFatura.NumeroPaginas % 2 == 0))
                    {
                        clienteComFatura.NumeroPaginas += 1;
                    }
                    ListaPaginas6.Add(clienteComFatura);
                }
                else if (clienteComFatura.NumeroPaginas > 6 && clienteComFatura.NumeroPaginas <= 12)
                {
                    if (!(clienteComFatura.NumeroPaginas % 2 == 0))
                    {
                        clienteComFatura.NumeroPaginas += 1;
                    }
                    ListaPagina12.Add(clienteComFatura);
                }
                else if (clienteComFatura.NumeroPaginas > 12)
                {
                    if (!(clienteComFatura.NumeroPaginas % 2 == 0))
                    {
                        clienteComFatura.NumeroPaginas += 1;
                    }
                    ListaPaginaMaiorQue12.Add(clienteComFatura);
                }
            }
        }

        public bool ValidaCEP(string cep)
        {
            cep = cep.Trim();
            int result = 0;
            if (cep.Length == 8)
            {
                int.TryParse(cep, out result);
                if (result > 0)
                    return true;

            }
            return false;

        }

        private static void PreencheDadosCliente(string linha, Cliente Cliente)
        {
            string[] DadosCliente = linha.Split(";");

            if (DadosCliente.Length == 8)
            {
                Cliente.NomeCompleto = DadosCliente[0];
                Cliente.CEP = DadosCliente[1];
                Cliente.RuaComComplemento = DadosCliente[2];
                Cliente.Bairro = DadosCliente[3];
                Cliente.Cidade = DadosCliente[4];
                Cliente.Estado = DadosCliente[5];
                Cliente.ValorFatura = Convert.ToDouble(DadosCliente[6]);
                Cliente.NumeroPaginas = int.Parse(DadosCliente[7]);
            }
            else
            {
                Cliente.NomeCompleto = DadosCliente[0];
                Cliente.CEP = DadosCliente[1];
                Cliente.RuaComComplemento = DadosCliente[2] + " " + DadosCliente[3];
                Cliente.Bairro = DadosCliente[4];
                Cliente.Cidade = DadosCliente[5];
                Cliente.Estado = DadosCliente[6];
                Cliente.ValorFatura = Convert.ToDouble(DadosCliente[7]);
                Cliente.NumeroPaginas = int.Parse(DadosCliente[8]);
            }
        }

        private void btnSelDiretorio_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);

                    txtDiretorio.Text = fbd.SelectedPath;
                    DiretorioSaida = fbd.SelectedPath;
                    btnSelecionaArquivo.Enabled = true;
                }
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNomeArquivo.Text))
            {
                MessageBox.Show("É necessário selecionar o diretório e um arquivo primeiro.", "Erro",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ClientesComFaturas = new List<Cliente>();
                ClientesSemFaturas = new List<Cliente>();


                if (tempListClientes.Count > 0)
                {
                    foreach (Cliente cliente in tempListClientes)
                    {
                        if (cliente.ValorFatura > 0)
                        {
                            ClientesComFaturas.Add(cliente);
                        }
                        else
                        {
                            ClientesSemFaturas.Add(cliente);
                        }
                    }
                    ListaPaginas6 = new List<Cliente>();
                    ListaPaginas12 = new List<Cliente>();
                    ListaPaginasMaiorQue12 = new List<Cliente>();
                    SeparacaoPorPaginas(ClientesComFaturas, ListaPaginas6, ListaPaginas12, ListaPaginasMaiorQue12, false);
                    SeparacaoPorPaginas(ClientesSemFaturas, ListaPaginas6, ListaPaginas12, ListaPaginasMaiorQue12, true);
                }

                CriacaoArquivo(ListaPaginas6, 1);
                CriacaoArquivo(ListaPaginas12, 2);
                CriacaoArquivo(ListaPaginasMaiorQue12, 3);

                MessageBox.Show("Arquivo verificado com sucesso, os arquivos estão disponíveis no diretório selecionado.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtDiretorio.Text = string.Empty;
            txtNomeArquivo.Text = string.Empty;
            btnSelecionaArquivo.Enabled = false;
        }
    }
}
