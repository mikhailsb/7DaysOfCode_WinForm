using CatAsService.Models;
using CatAsService.Uteis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatAsService
{
    public partial class frm_Favoritas : Form
    {
        public frm_Favoritas()
        {
            InitializeComponent();
            this.Text = "Buscar Raças Favoritas";
        }
        List<Cat> ListaGatos = new List<Cat>();
        List<MeusFavoritos> favoritos = new List<MeusFavoritos>();
        private void frm_Favoritas_Load(object sender, EventArgs e)
        {
            AtualizarListBox();
        }

        private void AtualizarListBox()
        {
            listBox1.Items.Clear();
            var JSON = ConsultaAPI.BuscaRacasGatoJson();
            //Cat gatos = new Cat();
            ListaGatos = Cat.Deserializer(JSON);
            var jsonFavos = MeusFavoritos.BuscarFavos();

            favoritos = MeusFavoritos.Deserialize(jsonFavos);

            foreach (var item in favoritos)
            {
                Cat gato = new Cat();
                gato = ListaGatos.Where(x => x.Id == item.Sub_Id).FirstOrDefault();

                listBox1.Items.Add(gato.Name);
            }
        }

        private async void btn_Excluir_Click(object sender, EventArgs e)
        {
            
            try
            {
                var nomeGato = listBox1.SelectedItem.ToString();

                var gatoDel = ListaGatos.Where(x => x.Name == nomeGato).FirstOrDefault();

                var idDel = favoritos.Where(x => x.Image_Id == gatoDel.Id).FirstOrDefault();

                var resposta = await Favoritar.DeletarFavorito(idDel);

                if (resposta.Contains("SUCCESS"))
                {
                    MessageBox.Show("Gato removido mas com respeito.", "Cat AS A Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarListBox();
                    btn_Excluir.Enabled = false;
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Selecione um Gato para remover dos favoritos.", "Cat AS A Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Excluir.Enabled = true;
        }
    }
}
