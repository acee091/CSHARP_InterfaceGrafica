namespace Aula_03___Interface_Gráfica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*lstNomes -> Items
         txtNome -> Text 
        Contagem de items -> .Count
        Verificar quem ta selecionado - SelectedIndices
        Remvoer o item -> .RemoveAt
        SelectedItem -> Um item por vez
        SelectedItems -> Vários itens por vez
        */

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            lstNomes.Items.Add(txtNome.Text);
            txtNome.Text = String.Empty;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstNomes.Items.Clear();
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
           /* for( int i = lstNomes.SelectedIndices.Count - 1; i >=0; i-- ) 
            {
                lstNomes.Items.RemoveAt(lstNomes.SelectedIndices[i]);
            }
           */
           if (lstNomes.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um nome para remover", "Nenhum nome foi selecionado!");
            }
           else
            {
                string item = lstNomes.SelectedItem.ToString(); 
                lstNomes.Items.Remove(item);
            }


        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string nome;
            nome = txtNome.Text;
            lstNomes.Items.Add(nome);
                if(lstNomes.SelectedIndex == -1) // Verificar o item selecionado:
                                                 // Número abaixo de 0, quer dizer que não há nada selecionado
                {
                    MessageBox.Show("Selecione um nome.", "Nenhum nome foi selecionado!!");
                }
                else
               {
                nome = lstNomes.SelectedItem.ToString();
                MessageBox.Show("O nome selecionado é "+ nome, "Verificação do nome");
            }
        }

        private void cmbNum_SelectedIndexChanged(object sender, EventArgs e)
        {            
                txtNum.Text = cmbNum.SelectedItem.ToString();
        }

        private void btnPreenche_Click(object sender, EventArgs e)
        {
            /*
           string[] numeros = new string[10] {"1", "2", "3","4", "5", "6", "7", "8", "9", "10"};
            cmbNum.Items.AddRange(numeros);
            */

            int i;
            for (i = 1; i <= 10; i++) 
            {
                cmbNum.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = txtNome.Text;
            string textoRemovido;
            int pos = texto.Length - 1; //Variável que mostra a última posição -- Propriedade LENGTH que traz o tamanho total do texto
            textoRemovido = texto.Remove(pos, 1); // Remove um caracter a partir da ultima posição do string                                
            txtNome.Text = textoRemovido;

            //Imutabilidade: Não é possivel alterar uma string, apenas uma variável
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void grpAnimal_Enter(object sender, EventArgs e)
        {

        }

        private void btnDesmarca_Click(object sender, EventArgs e)
        {
            radioCachorro.Checked = false;
            radioGato.Checked = false;
            radioFurao.Checked = false;
            btnDesmarca.Enabled = false; //Desabilitar o botão, a partir do momento que todos estão deselecionados
        }

        private void btnAnimal_Click(object sender, EventArgs e)
        {
            string animal = String.Empty;
            if (radioGato.Checked == true)  // Verificar qual animal foi cliclado
                animal = "Gato";
            else if (radioCachorro.Checked == true)
                animal = "Cachorro";
            else if (radioFurao.Checked == true)
                animal = "Furao";
            else
            {
                animal = "Burro"; // Se nenhum animal for clicado, aparece o burro e uma mensagem
                MessageBox.Show("Selecione um animal!!", "Erro de seleção");
            }
            // Utilizar duas barras no string, apenas uma barra (\) é utilizado como escape
            string imagem = "C:\\imagens\\" + animal + ".jpg";  // variavel que guarda o caminho da imagem + o nome do animal + o tipo do arquivo
            pictAnimal.ImageLocation = imagem; // caixa de imagem do PictureBox guarda o diretorio da imagem

            //true: habilita novamente os botões
            btnLimpaImagem.Enabled = true;
            btnDesmarca.Enabled = true;                    
        }

        private void btnLimpaImagem_Click(object sender, EventArgs e)
        {
            pictAnimal.Image = null; //Limpa a imagem da tela
            btnLimpaImagem.Enabled = false; //false: desabilitar botão 
        }

        private void btnProcuraImagem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(); // Mostra a caixa de dialógo
            string caminhoImagem = openFileDialog1.FileName; // Obter o caminho da imagem da caixa de dialógo
            pictAnimal.ImageLocation = caminhoImagem;  //Carregar o arquivo selecionado no PictureBox
        }
    }
}