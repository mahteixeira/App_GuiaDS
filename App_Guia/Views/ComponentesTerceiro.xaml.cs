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
    public partial class ComponentesTerceiro : ContentPage
    {
        public ComponentesTerceiro()
        {
            InitializeComponent();
        }

        private async void Btn_SegSistInf(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Segurança de Sistemas de Informação  ",
                    AtribuicoesResponsabilidades = "Implementar rotinas de segurança da informação. ",
                    ValoresAtitudes = "• Estimular atitudes respeitosas. " +
                    "\n\n• Incentivar comportamentos éticos. " +
                    "\n\n• Desenvolver a criticidade.  "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Btn_MobII(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Programação de Aplicativos Mobile II ",
                    AtribuicoesResponsabilidades = "Documentar, construir e manter sistemas de informação para plataformas móveis. ",
                    ValoresAtitudes = "• Responsabilizar-se pela produção, utilização e divulgação de informações. " +
                    "\n\n• Incentivar a criatividade. " +
                    "\n\n• Estimular a organização "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Btn_PWebIII(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Programação Web III  ",
                    AtribuicoesResponsabilidades = "Documentar, construir e manter sistemas de informação para web ",
                    ValoresAtitudes = "• Responsabilizar-se pela produção, utilização e divulgação de informações. " +
                    "\n\n• Fortalecer a persistência e o interesse na resolução de situações-problema. " +
                    "\n\n• Incentivar a criatividade. "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Btn_QualiSof(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Qualidade e Teste de Software  ",
                    AtribuicoesResponsabilidades = "Testar softwares para melhoria da qualidade de sistemas. • Elaborar registros e planilhas de acompanhamento e controle das atividades.  ",
                    ValoresAtitudes = "• Responsabilizar-se pela produção, utilização e divulgação de informações. " +
                    "\n\n• Estimular a proatividade. " +
                    "\n\n• Desenvolver criticidade. " +
                    "\n\n• Incentivar comportamentos éticos "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Btn_TCC(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Desenvolvimento do Trabalho de Conclusão de Curso (TCC) em Desenvolvimento de Sistemas   ",
                    AtribuicoesResponsabilidades = "Planejar e desenvolver projetos de sistemas computacionais.  ",
                    ValoresAtitudes = "• Planejar ações mais eficazes no desenvolvimento de sistemas. " +
                    "\n\n• Demonstrar comprometimento com equipe e o trabalho.  "
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
    }
}