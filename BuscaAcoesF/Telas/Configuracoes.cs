using AutoMapper;
using BuscaAcoes.Dominio.Auxiliar;
using BuscaAcoes.Dominio.Dtos;
using BuscaAcoes.Dominio.Entidades;
using BuscaAcoes.Dominio.Interfaces.Servicos;
using BuscaAcoesF.Formularios.Estilo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeBroker.Telas
{
    public partial class Configuracoes : FormBase
    {
        private readonly IMapper _mapper;
        private readonly IServicoConfiguracao _servicoConfiguracao;
        private readonly ConfiguracoesSistema _configuracacoesSistema;
        public Configuracoes(IMapper mapper,
            IServicoConfiguracao servicoConfiguracao,
            ConfiguracoesSistema configuracacoesSistema)
            : base(configuracacoesSistema)
        {
            InitializeComponent();
            FormatarTela(this);

            _mapper = mapper;
            _servicoConfiguracao = servicoConfiguracao;
            _configuracacoesSistema = configuracacoesSistema;
        }

        private async void btnAplicar_Click(object sender, EventArgs e)
        {
            var configuracao = await ValidarDadosConfiguracao();

            await _servicoConfiguracao.Atualizar(configuracao);

            _configuracacoesSistema.Config = configuracao;

            this.Close();
        }

        private async Task<Configuracao> ValidarDadosConfiguracao()
        {
            var configuracoes = new ConfiguracaoDto(ckbModoDesenvolvimento.Checked,
                   Convert.ToInt32(numTempoAtualizacaoDados.Value),
                   txtNomeUsuario.Text,
                   txtMensagemErroOrigem.Text,
                   txtHoraInicioMonitoramento.Text,
                   txtHoraFimMonitoramento.Text,
                   Convert.ToInt32(txtPorcentagemVariacao.Text));

            if (!configuracoes.Valido)
                MessageBox.Show(configuracoes.Notificacoes.Aggregate((A, B) => A + "," + B), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return await Task.FromResult(_mapper.Map<Configuracao>(configuracoes));
        }

        private async void Configuracoes_Load(object sender, EventArgs e)
        {
            //var configuracao = await _servicoConfiguracao.Obter();

            PreencherDados(_configuracacoesSistema.Config);
        }

        private void PreencherDados(Configuracao configuracao)
        {
            if (configuracao == null) return;
            ckbModoDesenvolvimento.Checked = configuracao.ModoDesenvolvimento;
            numTempoAtualizacaoDados.Value = configuracao.TempoAtualizacaoDados;
            txtNomeUsuario.Text = configuracao.NomeUsuario;
            txtMensagemErroOrigem.Text = configuracao.MensagemErroOrigem;
            txtHoraInicioMonitoramento.Text = configuracao.HoraInicioAtualizacaoDados;
            txtHoraFimMonitoramento.Text = configuracao.HoraFimAtualizacaoDados;
            txtPorcentagemVariacao.Value = configuracao.PorcentagemVariavao;
        }
    }
}
