using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App_Guia.Models;

namespace App_Guia.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComponentesSegundo : ContentPage
    {
        public ComponentesSegundo()
        {
            InitializeComponent();
        }

        private async void Btn_Etica(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Ética e Cidadania Organizacional  ",
                    AtribuicoesResponsabilidades = "Atuar de acordo com princípios éticos nas relações de trabalho.  ",
                    ValoresAtitudes = "• Estimular atitudes respeitosas. " +
                    "\n\n• Incentivar comportamentos éticos. " +
                    "\n\n• Comprometer-se com a igualdade de direitos.  "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Btn_DS(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Desenvolvimento de Sistemas",
                    AtribuicoesResponsabilidades = "Analisar e projetar sistemas de informação, selecionando linguagens de programação e ambientes de desenvolvimento de acordo com as especificidades do projeto. Codificar e depurar programas. ",
                    ValoresAtitudes = "• Fortalecer a persistência e o interesse na resolução de situações-problema. " +
                    "\n\n• Incentivar ações que promovam a cooperação. " +
                    "\n\n• Desenvolver a criatividade. "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Btn_BDadosII(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Banco de Dados II ",
                    AtribuicoesResponsabilidades = "Implementar banco de dados. ",
                    ValoresAtitudes = "• Incentivar a criatividade. " +
                    "\n\n• Desenvolver a criticidade. " +
                    "\n\n• Fortalecer a persistência e o interesse na resolução de situações-problema "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Btn_SistEmb(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Sistemas Embarcados  ",
                    AtribuicoesResponsabilidades = "Desenvolver sistemas embarcados.  ",
                    ValoresAtitudes = "• Fortalecer a persistência e o interesse na resolução de situações-problema. " +
                    "\n\n• Estimular a organização. " +
                    "\n\n• Incentivar a criatividade. "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Btn_MobI(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Programação de Aplicativos Mobile I ",
                    AtribuicoesResponsabilidades = "Elaborar projetos de aplicativos para plataformas móveis. ",
                    ValoresAtitudes = "• Incentivar a criatividade. " +
                    "\n\n• Responsabilizar-se pela produção, utilização e divulgação de informações. " +
                    "\n\n• Estimular a organização.  "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Btn_PWebII(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Programação Web II",
                    AtribuicoesResponsabilidades = "Planejar projetos de sistemas de informação para web ",
                    ValoresAtitudes = "• Responsabilizar-se pela produção, utilização e divulgação de informações. " +
                    "\n\n• Fortalecer a persistência e o interesse na resolução de situações-problema. " +
                    "\n\n• Incentivar a criatividade.  "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
    }
}