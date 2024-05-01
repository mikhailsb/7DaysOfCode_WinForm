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
    public partial class frm_BuscarRacas : Form
    {
        public frm_BuscarRacas()
        {
            InitializeComponent();
            this.Text = "Buscar Raças";
            CarregarCbxComRacas();
        }
        List<Cat> gatos = new List<Cat>();
        ImageGatinho img = new ImageGatinho();
        Favoritar CadFav = new Favoritar();
        private void CarregarCbxComRacas()
        {
            var JSON = ConsultaAPI.BuscaRacasGatoJson();
            //Cat gatos = new Cat();
            gatos = Cat.Deserializer(JSON);

            List<string> racas = new List<string>();
            foreach (var item in gatos)
            {
                cbx_RacasGato.Items.Add(item.Name);
            }
        }
        private async void btn_Buscar_Click(object sender, EventArgs e)
        {
            string raca = cbx_RacasGato.SelectedItem.ToString();

            try
            {
                foreach (var item in gatos)
                {
                    if (item.Name == raca)
                    {
                        img = await ImageGatinho.BuscarImagemGato(item.Id);
                        lbl_ResultDescricao.Text = item.Description;
                        lbl_ResultOrigem.Text = item.Origin;
                        lbl_ResultTemperamento.Text = item.Temperament;
                        CadFav.image_id = item.Id;
                        CadFav.sub_id = item.Id;
                    }
                }

                pictureBox1.Load(img.url.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cat As A Service - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_favoritar_Click(object sender, EventArgs e)
        {
            string retorno;

            try
            {
                if (CadFav.image_id == null)
                {
                    MessageBox.Show("Busca não realizada. \nPor gentileza, efetue a busca do Gato.", "Cat As A Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    retorno = await CadFav.AdicionarFavoritos(CadFav);

                    if (retorno.Contains("SUCCESS"))
                    {
                        MessageBox.Show("Gato favoritado com sucesso.", "Cat As A Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Cat As A Service - Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void cbx_RacasGato_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Load(@"..\..\Imagens\Iconka-Meow-2-Cat-upsidedown.256.png");
            lbl_ResultDescricao.Text = null;
            lbl_ResultOrigem.Text = null;
            lbl_ResultTemperamento.Text = null;
            CadFav.image_id = null;
            CadFav.sub_id = null;
            btn_Buscar.Enabled = true;
        }
    }
}
