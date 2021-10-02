using CodeItAirlines.Comuns.Extensions;
using CodeItAirlines.Domain.Dtos;
using CodeItAirlines.RegraDeNegocio.Tripulante;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using static CodeItAirlines.Domain.Entidades.TripulanteEntidade;
using static CodeItAirlines.RegraDeNegocio.Tripulante.TransporteTripulantes;

namespace CodeItAirlines.Interfaces
{
    public partial class Principal : Form
    {
        private static TransporteTripulantes Terminal;
        private static TransporteTripulantes Veiculo;
        private static TransporteTripulantes Aviao;
        private static int tempoAcoes = 1500;

        private string log, ocorrencias;
        private List<TripulanteDto> listaAuxiliarTripulantes;

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            MontarCenario();
        }

        private void MontarCenario()
        {
            var controle = new TripulanteControle();
            var listaTripulantesTerminal = controle.ObterListaTripulantes();
            CarregaImagens(listaTripulantesTerminal);
            dgv_aeroporto.DataSource = listaTripulantesTerminal;

            var listaTripulantesCarrinho = new List<TripulanteDto>();
            var listaTripulantesAviao = new List<TripulanteDto>();

            Terminal = new TransporteTripulantes(listaTripulantesTerminal, TransporteTripulantes.TipoTransporteTripulanteEnum.Terminal);
            Veiculo = new TransporteTripulantes(listaTripulantesCarrinho, TransporteTripulantes.TipoTransporteTripulanteEnum.Veiculo);
            Aviao = new TransporteTripulantes(listaTripulantesAviao, TransporteTripulantes.TipoTransporteTripulanteEnum.Aviao);
        }

        private void CarregaImagens(List<TripulanteDto> listaTripulantes)
        {
            foreach (var tripulante in listaTripulantes)
            {
                SetarImagemConformeTipo(tripulante);
            }
        }

        private void SetarImagemConformeTipo(TripulanteDto tripulante)
        {
            switch (tripulante.TipoTripulante)
            {
                case TipoTripulanteEnum.Piloto:
                    tripulante.Imagem = Properties.Resources.piloto;
                    return;
                case TipoTripulanteEnum.ChefeServico:
                    tripulante.Imagem = Properties.Resources.chefeServico;
                    return;
                case TipoTripulanteEnum.Comissaria:
                    tripulante.Imagem = Properties.Resources.comissaria;
                    return;
                case TipoTripulanteEnum.Oficial:
                    tripulante.Imagem = Properties.Resources.oficial;
                    return;
                case TipoTripulanteEnum.Policial:
                    tripulante.Imagem = Properties.Resources.policial;
                    return;
                case TipoTripulanteEnum.Presidiario:
                    tripulante.Imagem = Properties.Resources.presidiario;
                    return;
            }
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            btn_iniciar.Visible = false;
            Thread tarefa = new Thread(TarefaEmbarque);
            tarefa.Start();
        }

        public void TarefaEmbarque()
        {
            List<TipoTripulanteEnum> solicitacaoTripulantes = new List<TipoTripulanteEnum>();

            solicitacaoTripulantes.Clear();
            solicitacaoTripulantes.Add(TipoTripulanteEnum.Piloto);
            solicitacaoTripulantes.Add(TipoTripulanteEnum.ChefeServico);
            DesembarcarDoisDoTerminal(solicitacaoTripulantes);

            EmbarcarDoisNoVeiculo();

            DesembarcarDoisDoVeiculo();

            EmbarcarDoisNoAviao();

            solicitacaoTripulantes.Clear();
            solicitacaoTripulantes.Add(TipoTripulanteEnum.Piloto);
            DesembarcarUmDoAviao(solicitacaoTripulantes);

            EmbarcarUmNoVeiculo();

            DesembarcarUmDoVeiculo();

            EmbarcarUmNoTerminal();

            solicitacaoTripulantes.Clear();
            solicitacaoTripulantes.Add(TipoTripulanteEnum.Policial);
            solicitacaoTripulantes.Add(TipoTripulanteEnum.Presidiario);
            DesembarcarDoisDoTerminal(solicitacaoTripulantes);

            EmbarcarDoisNoVeiculo();

            DesembarcarDoisDoVeiculo();

            EmbarcarDoisNoAviao();

            solicitacaoTripulantes.Clear();
            solicitacaoTripulantes.Add(TipoTripulanteEnum.ChefeServico);
            DesembarcarUmDoAviao(solicitacaoTripulantes);

            EmbarcarUmNoVeiculo();

            DesembarcarUmDoVeiculo();

            EmbarcarUmNoTerminal();

            solicitacaoTripulantes.Clear();
            solicitacaoTripulantes.Add(TipoTripulanteEnum.ChefeServico);
            solicitacaoTripulantes.Add(TipoTripulanteEnum.Comissaria);
            DesembarcarDoisDoTerminal(solicitacaoTripulantes);

            EmbarcarDoisNoVeiculo();

            DesembarcarDoisDoVeiculo();

            EmbarcarDoisNoAviao();

            solicitacaoTripulantes.Clear();
            solicitacaoTripulantes.Add(TipoTripulanteEnum.ChefeServico);
            DesembarcarUmDoAviao(solicitacaoTripulantes);

            EmbarcarUmNoVeiculo();

            DesembarcarUmDoVeiculo();

            EmbarcarUmNoTerminal();

            solicitacaoTripulantes.Clear();
            solicitacaoTripulantes.Add(TipoTripulanteEnum.ChefeServico);
            solicitacaoTripulantes.Add(TipoTripulanteEnum.Comissaria);
            DesembarcarDoisDoTerminal(solicitacaoTripulantes);

            EmbarcarDoisNoVeiculo();

            DesembarcarDoisDoVeiculo();

            EmbarcarDoisNoAviao();

            solicitacaoTripulantes.Clear();
            solicitacaoTripulantes.Add(TipoTripulanteEnum.ChefeServico);
            DesembarcarUmDoAviao(solicitacaoTripulantes);

            EmbarcarUmNoVeiculo();

            DesembarcarUmDoVeiculo();

            EmbarcarUmNoTerminal();

            solicitacaoTripulantes.Clear();
            solicitacaoTripulantes.Add(TipoTripulanteEnum.Piloto);
            solicitacaoTripulantes.Add(TipoTripulanteEnum.ChefeServico);
            DesembarcarDoisDoTerminal(solicitacaoTripulantes);

            EmbarcarDoisNoVeiculo();

            DesembarcarDoisDoVeiculo();

            EmbarcarDoisNoAviao();

            solicitacaoTripulantes.Clear();
            solicitacaoTripulantes.Add(TipoTripulanteEnum.Piloto);
            DesembarcarUmDoAviao(solicitacaoTripulantes);

            EmbarcarUmNoVeiculo();

            DesembarcarUmDoVeiculo();

            EmbarcarUmNoTerminal();

            solicitacaoTripulantes.Clear();
            solicitacaoTripulantes.Add(TipoTripulanteEnum.Piloto);
            solicitacaoTripulantes.Add(TipoTripulanteEnum.Oficial);
            DesembarcarDoisDoTerminal(solicitacaoTripulantes);

            EmbarcarDoisNoVeiculo();

            DesembarcarDoisDoVeiculo();

            EmbarcarDoisNoAviao();

            solicitacaoTripulantes.Clear();
            solicitacaoTripulantes.Add(TipoTripulanteEnum.Piloto);
            DesembarcarUmDoAviao(solicitacaoTripulantes);

            EmbarcarUmNoVeiculo();

            DesembarcarUmDoVeiculo();

            EmbarcarUmNoTerminal();

            solicitacaoTripulantes.Clear();
            solicitacaoTripulantes.Add(TipoTripulanteEnum.Piloto);
            solicitacaoTripulantes.Add(TipoTripulanteEnum.Oficial);
            DesembarcarDoisDoTerminal(solicitacaoTripulantes);

            EmbarcarDoisNoVeiculo();

            DesembarcarDoisDoVeiculo();

            EmbarcarDoisNoAviao();

            img_fim.Invoke((MethodInvoker)delegate { img_fim.Visible = true; });
            lbl_fim.Invoke((MethodInvoker)delegate { lbl_fim.Visible = true; });

            tb_Log.Invoke((MethodInvoker)delegate { tb_Log.AppendText("\nTodos Embarcados!"); });

        }

        private void EmbarcarUmNoTerminal()
        {
            Terminal.EmbarcarTripulante(listaAuxiliarTripulantes[0]);
            dgv_aeroporto.Invoke((MethodInvoker)delegate { dgv_aeroporto.DataSource = Terminal.ObterCopiaListaPassageiros(); });
            log = ObterLogEmbarcouTripulante(TipoTransporteTripulanteEnum.Terminal, listaAuxiliarTripulantes[0]);
            tb_Log.Invoke((MethodInvoker)delegate { tb_Log.AppendText(log); });
            Thread.Sleep(tempoAcoes);
        }

        private void DesembarcarUmDoVeiculo()
        {
            Veiculo.DesembargarTripulantes();
            dgv_carrinho.Invoke((MethodInvoker)delegate { dgv_carrinho.DataSource = Veiculo.ObterCopiaListaPassageiros(); });
            log = ObterLogDesembarcouTripulante(TipoTransporteTripulanteEnum.Veiculo, listaAuxiliarTripulantes[0]);
            tb_Log.Invoke((MethodInvoker)delegate { tb_Log.AppendText(log); });
            Thread.Sleep(tempoAcoes);
        }

        private void EmbarcarUmNoVeiculo()
        {
            Veiculo.EmbarcarTripulante(listaAuxiliarTripulantes[0]);
            dgv_carrinho.Invoke((MethodInvoker)delegate { dgv_carrinho.DataSource = Veiculo.ObterCopiaListaPassageiros(); });
            log = ObterLogEmbarcouTripulante(TipoTransporteTripulanteEnum.Veiculo, listaAuxiliarTripulantes[0]);
            tb_Log.Invoke((MethodInvoker)delegate { tb_Log.AppendText(log); });
            Thread.Sleep(tempoAcoes);
        }

        private void DesembarcarUmDoAviao(List<TipoTripulanteEnum> solicitacaoTripulantes)
        {
            listaAuxiliarTripulantes = Aviao.ObterTripulantesPorTipos(solicitacaoTripulantes, ocorrencias);
            dgv_aviao.Invoke((MethodInvoker)delegate { dgv_aviao.DataSource = Aviao.ObterCopiaListaPassageiros(); });
            log = ObterLogDesembarcouTripulante(TipoTransporteTripulanteEnum.Aviao, listaAuxiliarTripulantes[0]);
            tb_Log.Invoke((MethodInvoker)delegate { tb_Log.AppendText(log); });
            Thread.Sleep(tempoAcoes);
        }

        private void EmbarcarDoisNoAviao()
        {
            Aviao.EmbarcarDoisTripulante(listaAuxiliarTripulantes[0], listaAuxiliarTripulantes[1]);
            dgv_aviao.Invoke((MethodInvoker)delegate { dgv_aviao.DataSource = Aviao.ObterCopiaListaPassageiros(); });
            log = ObterLogEmbarcaramDoisTripulantes(TipoTransporteTripulanteEnum.Aviao, listaAuxiliarTripulantes);
            tb_Log.Invoke((MethodInvoker)delegate { tb_Log.AppendText(log); });
            Thread.Sleep(tempoAcoes);
        }

        private void DesembarcarDoisDoVeiculo()
        {
            Veiculo.DesembargarTripulantes();
            dgv_carrinho.Invoke((MethodInvoker)delegate { dgv_carrinho.DataSource = Veiculo.ObterCopiaListaPassageiros(); });
            log = ObterLogDesembarcaramDoisTripulantes(TipoTransporteTripulanteEnum.Veiculo, listaAuxiliarTripulantes);
            tb_Log.Invoke((MethodInvoker)delegate { tb_Log.AppendText(log); });
            Thread.Sleep(tempoAcoes);
        }

        private void DesembarcarDoisDoTerminal(List<TipoTripulanteEnum> solicitacaoTripulantes)
        {
            listaAuxiliarTripulantes = Terminal.ObterTripulantesPorTipos(solicitacaoTripulantes, ocorrencias);
            dgv_aeroporto.Invoke((MethodInvoker)delegate { dgv_aeroporto.DataSource = Terminal.ObterCopiaListaPassageiros(); });
            log = ObterLogDesembarcaramDoisTripulantes(TipoTransporteTripulanteEnum.Terminal, listaAuxiliarTripulantes);
            tb_Log.Invoke((MethodInvoker)delegate { tb_Log.AppendText(log); });
            Thread.Sleep(tempoAcoes);
        }

        private void EmbarcarDoisNoVeiculo()
        {
            Veiculo.EmbarcarDoisTripulante(listaAuxiliarTripulantes[0], listaAuxiliarTripulantes[1]);
            dgv_carrinho.Invoke((MethodInvoker)delegate { dgv_carrinho.DataSource = Veiculo.ObterCopiaListaPassageiros(); });
            log = ObterLogEmbarcaramDoisTripulantes(TipoTransporteTripulanteEnum.Veiculo, listaAuxiliarTripulantes);
            tb_Log.Invoke((MethodInvoker)delegate { tb_Log.AppendText(log); });
            Thread.Sleep(tempoAcoes);
        }

        private string ObterLogDesembarcaramDoisTripulantes(TipoTransporteTripulanteEnum tipoTransporte, List<TripulanteDto> tripulantes)
        {
            var mensagem = "\nDesembarcaram do {0}, {1} e {2}";
            return string.Format(mensagem, tipoTransporte.GetDescription(), 
                tripulantes[0].NomeComCargo, tripulantes[1].NomeComCargo).ToString();
        }

        private string ObterLogEmbarcaramDoisTripulantes(TipoTransporteTripulanteEnum tipoTransporte, List<TripulanteDto> tripulantes)
        {
            var mensagem = "\nEmbarcaram no {0}, {1} e {2}";
            return string.Format(mensagem, tipoTransporte.GetDescription(),
                tripulantes[0].NomeComCargo, tripulantes[1].NomeComCargo);
        }

        private string ObterLogDesembarcouTripulante(TipoTransporteTripulanteEnum tipoTransporte, TripulanteDto tripulante)
        {
            var mensagem = "\nDesembarcou do {0}, {1}";
            return string.Format(mensagem, tipoTransporte.GetDescription(),
                tripulante.NomeComCargo).ToString();
        }

        private string ObterLogEmbarcouTripulante(TipoTransporteTripulanteEnum tipoTransporte, TripulanteDto tripulante)
        {
            var mensagem = "\nEmbarcou no {0}, {1}";
            return string.Format(mensagem, tipoTransporte.GetDescription(),
                tripulante.NomeComCargo).ToString();
        }
    }
}
