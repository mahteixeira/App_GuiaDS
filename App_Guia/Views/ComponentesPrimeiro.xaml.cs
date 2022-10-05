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
    public partial class ComponentesPrimeiro : ContentPage
    {
        public ComponentesPrimeiro()
        {
            InitializeComponent();
        }


        private async void Btn_BDadosI(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Banco de Dados I",
                    AtribuicoesResponsabilidades = "Modelar banco de dados ",
                    ValoresAtitudes = "Estimular a organização. • Fortalecer a persistência e o interesse na resolução de situações-problema. • Promover ações que considerem o respeito às normas estabelecidas."
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Btn_Analise(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Análise e Projeto de Sistemas",
                    AtribuicoesResponsabilidades = "Elaborar projetos de sistema de informação.  ",
                    ValoresAtitudes = "Estimular a organização. • Incentivar a criatividade. • Fortalecer a persistência e o interesse na resolução de situações-problema.  "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }

        private async void Btn_Design(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Design Digital",
                    AtribuicoesResponsabilidades = "Desenvolver elementos gráficos para aplicativos e sites.  ",
                    ValoresAtitudes = "Incentivar a criatividade. • Respeitar as manifestações culturais de outros povos. • Incentivar ações que promovam a cooperação. "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Btn_PWebI(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Programação Web I",
                    AtribuicoesResponsabilidades = "Desenvolver sites para Web ",
                    ValoresAtitudes = "Incentivar a criatividade. • Estimular a organização. • Fortalecer a persistência e o interesse na resolução de situações-problema.  "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Btn_FundInf(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Fundamentos da Informática",
                    AtribuicoesResponsabilidades = "Operar sistemas computacionais.  ",
                    ValoresAtitudes = "Desenvolver a criticidade. • Incentivar comportamentos éticos. • Promover ações que considerem o respeito às normas estabelecidas.  "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Btn_TecProAlg(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Técnicas de Programação e Algoritimo",
                    AtribuicoesResponsabilidades = "Desenvolver programas de computador, utilizando princípios de boas práticas. • Realizar versionamento no desenvolvimento de programas.  • Verificar usabilidade no desenvolvimento de programas.  ",
                    ValoresAtitudes = "Incentivar a criatividade. • Incentivar comportamentos éticos. • Fortalecer a persistência e o interesse na resolução de situações-problema. "
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