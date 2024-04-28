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

            ImageGatinho img = new ImageGatinho();

            foreach (var item in gatos)
            {
                if (item.Name == raca)
                {
                    lbl_ResultDescricao.Text = item.Description;
                    lbl_ResultOrigem.Text = item.Origin;
                    lbl_ResultTemperamento.Text = item.Temperament;
                    img = await ImageGatinho.Desserializer(item.Id);
                }
            }
            
            pictureBox1.Load(img.url.ToString());
        }
    }
}
